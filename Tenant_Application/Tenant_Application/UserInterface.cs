using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Data.Common;
using System.Configuration;
using System.Net.Sockets;
using System.Threading;

namespace Tenant_Application
{
    public partial class UserInterfaceForm : Form
    {


        DataAccess db = new DataAccess();

        List<int> temporaryScoreboard = new List<int>();


        int personId;
        string personEmail;
        string personPassword;


        //creating a list to store account TEMP
        BindingList<Account> accounts = new BindingList<Account>();
        BindingList<Chore> chores = new BindingList<Chore>();
        BindingList<Announcement> annoucements = new BindingList<Announcement>();

        string msg = "";
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED //cause that makes sense ~ by Michael_gvdw //it actually helps a bit - this + doublebuffering
                return cp;
            }
        }



        public UserInterfaceForm(int personId, string personEmail, string personPassword)
        {
            InitializeComponent();

            //Get data passed from login screen
            this.personId = personId;
            this.personEmail = personEmail;
            this.personPassword = personPassword;

            timerAnnDisp.Start();



            UDPConnection data = new UDPConnection();
            Thread thdUDPServer = new Thread(new ThreadStart(data.ReceiveUDP));
            thdUDPServer.Start();
            ListBox.CheckForIllegalCrossThreadCalls = false;
            TextBox.CheckForIllegalCrossThreadCalls = false;
            lbxCalendarChores.DataSource = accounts;
            lbxCalendarChores.DisplayMember = "FullInfo";
        }

        private void UserInterfaceForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            Days();
            Scoreboard();
        }

        //Closes entire app
        private void UserInterfaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        //Closes entire app
        private void UserInterfaceForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(-1);
        }

        //Temporary populating the calendar
        private void Days()
        {
            lbxCalendarDays.Items.Add("Monday");
            lbxCalendarDays.Items.Add("Tuesday");
            lbxCalendarDays.Items.Add("Wednesday");
            lbxCalendarDays.Items.Add("Thursday");
            lbxCalendarDays.Items.Add("Friday");
            lbxCalendarDays.Items.Add("Saturday");
            lbxCalendarDays.Items.Add("Sunday");
        }

        private void SendMail(string complaint) {
            tbxComplaint.Clear();

            // ONLY Gmail accounts that have "Use LESS secure apps" ENABLED will work!!!!!
            try
            {
                var fromAddress = new MailAddress(personEmail);
                var toAddress = new MailAddress("tenantcomplaints69@gmail.com", "Joseph Stalin");
                string fromPassword = personPassword;
                const string subject = "Complaint";
                string body = complaint;

                var smtp = new SmtpClient
                {
                    //Don't change these settings
                    Host = "smtp.gmail.com",
                    Port = 587,
                    EnableSsl = true,
                    DeliveryMethod = SmtpDeliveryMethod.Network,
                    UseDefaultCredentials = false,
                    Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
                };
                using (var message = new MailMessage(fromAddress, toAddress)
                {
                    Subject = subject,
                    Body = body
                })
                {
                    smtp.Send(message);
                }

                MsgBoxInformation("Thank you for your contacting us. We will review your complain, and get back to you as soon as possible!");
            } catch (Exception ex){
                MsgBoxWarning(ex.ToString());
            }
        }

        private void BtnSendMail_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxComplaint.Text))
            {
                SendMail(tbxComplaint.Text);
            }
            else
            {
                MsgBoxWarning("You need to enter a complaint!");
            }


        }

   


        private void BtnAnnComplaints_Click(object sender, EventArgs e)
        {
            panelAnnComplaints.Visible = HidePanel(panelAnnComplaints.Visible);
        }

        bool HidePanel(bool panelInfo)
        {
            if (panelInfo)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        //Will be changed to a method after we do the connection
        string announceDisplay = "";
        private void Button1_Click_1(object sender, EventArgs e)
        {
            tbxAnnComplaints.Text = "";

            //Resets the timer in case a new announcement comes in
            timerAnnouncement.Enabled = false;
            timerAnnouncement.Enabled = true;


            DateTime dt = DateTime.Today;
            string hour = dt.ToShortDateString();

            //Change the text in msg with the announcement coming from wherever 
            msg = textBox1.Text;

            string addmsg = msg;
            string current = ($"[{hour}]  {msg}" + Environment.NewLine);
            tbxAnnChat.Text = announceDisplay + current;
            tbxAnnComplaints.Text = announceDisplay + current;
            tbxAnnCalendar.Text = announceDisplay + current;
            tbxAnnScore.Text = announceDisplay + current;

            announceDisplay = tbxAnnComplaints.Text;

            if (msg.Length > 20)
            {
                //at 20th character - ...
                addmsg = msg.Substring(0, 20);
                addmsg += " ...";
            }

        }






        string lblMsgs = "";
        string current = "";

        private void TimerRefreshUDP_Tick(object sender, EventArgs e)
        {
            UDPConnection data = new UDPConnection();
            if (data.isReceived)
            {
                current = data.ReturnUDP();
                RefreshChat();
                data.isReceived = false;
            }
        }

        private void RefreshChat()
        {
            DateTime dt = DateTime.Today;
            string hour = dt.ToShortDateString();

            tbxChat.Text = $"{lblMsgs}[{hour}] Gosho:    {current} {Environment.NewLine}";
            lblMsgs = tbxChat.Text;
            tbxChatMsg.Clear();
        }

        private void BtnChatSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxChatMsg.Text))
            {
                //do nothing
            }
            else
            {
                current = tbxChatMsg.Text;
                UDPConnection data = new UDPConnection();
                data.SendUDP(current);
                RefreshChat();
            }
        }

        private void BtnCalendarSelect_Click(object sender, EventArgs e)
        {
            if(lbxCalendarChores.SelectedIndex != -1)
            {
                //You need to send the chore you chose to the database - it's already taken
                MsgBoxInformation($"You chose to: {lbxCalendarChores.SelectedItem}");
                lbxCalendarChores.Items.Remove(lbxCalendarChores.SelectedItem);
            }
            else
            {
                MsgBoxWarning("Choose a chore first");
            }
        }



        private void Scoreboard()
        {
            temporaryScoreboard.Add(5);
            temporaryScoreboard.Add(3);
            temporaryScoreboard.Add(4);
            lbxScoreboard.Items.Add($"Joe - {temporaryScoreboard[0]}");
            lbxScoreboard.Items.Add($"Sam - {temporaryScoreboard[1]}");
            lbxScoreboard.Items.Add($"Bob - {temporaryScoreboard[2]}");
        }

        private void LbxCalendarDays_Click(object sender, EventArgs e)
        {
            if(lbxCalendarDays.SelectedIndex != -1)
            {
                switch (lbxCalendarDays.SelectedIndex)
                {
                    case 0:
                        lbxCalendarChores.Items.Clear();
                        lbxCalendarChores.Items.Add("Clean sink and shit");
                        lbxCalendarChores.Items.Add("Dishes");
                        break;
                    case 1:
                        lbxCalendarChores.Items.Clear();
                        lbxCalendarChores.Items.Add("Fix toilet");
                        lbxCalendarChores.Items.Add("Vacuum");
                        break;
                }
            }
        }

        private void btnTempDB_Click(object sender, EventArgs e)
        {
            accounts.Clear();
            //getting access to the database
            DataAccess db = new DataAccess();
            //getting the account through the textbox TEMP
            foreach (var account in db.GetUsername(tbAccount.Text))
            {
                accounts.Add(account);
            }
        }


                        /*Handle Announcement*/

        int lastLength = 0; //Keeps track if new announcemment is added
        //Disp new announcement as pop-up
        private void TimerAnnDisp_Tick(object sender, EventArgs e)
        {
            //if (db.GetAnnouncement().Count != lastLength)
            //{
            //    lastLength = db.GetAnnouncement().Count;

            //    string ann = db.GetAnnouncement()[db.GetAnnouncement().Count - 1].Date + db.GetAnnouncement()[db.GetAnnouncement().Count - 1].Annoucement;

            //    if (ann.Length > 20)
            //    {
            //        //at 20th character - ...
            //        msg = ann.Substring(0, 20);
            //        msg += " ...";
            //    }

            //    lblAnnComplaints.Text = msg;
            //    lblAnnChat.Text = msg;
            //    lblAnnCalendar.Text = msg;
            //    lblAnnScore.Text = msg;

            //    timerAnnouncement.Start();
            //}
        }

        //Rmv new announcement as pop-up
        private void TimerAnnouncement_Tick(object sender, EventArgs e)
        {
            lblAnnComplaints.Text = "";
            lblAnnChat.Text = "";
            lblAnnCalendar.Text = "";
            lblAnnScore.Text = "";
            timerAnnouncement.Stop();
        }

        //Open/Close the announcememnt panel
        private void BtnAnnCalendar_Click(object sender, EventArgs e)
        {
            panelAnnCalendar.Visible = HidePanel(panelAnnCalendar.Visible);

            try
            {
                List<Announcement> listAnn = db.GetAnnouncement();

                RstAnnPanel(); //Clear the panel

                //Add the announcements to the announcement panel
                foreach (Announcement a in listAnn)
                {
                    tbxAnnChat.Text += a.Date + a.Annoucement + "\n";
                    tbxAnnComplaints.Text += a.Date + a.Annoucement + "\n";
                    tbxAnnCalendar.Text += a.Date + a.Annoucement + "\n";
                    tbxAnnScore.Text += a.Date + a.Annoucement + "\n";
                }
            }
            catch (Exception ex)
            {
                MsgBoxWarning(ex.ToString());
            }
        }
        /*End Handle Announcement*/

        private void RstAnnPanel() {
            tbxAnnChat.Text = "";
            tbxAnnComplaints.Text = "";
            tbxAnnCalendar.Text = "";
            tbxAnnScore.Text = "";
        }

        public void MsgBoxWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void MsgBoxInformation(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
