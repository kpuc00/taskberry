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


namespace Tenant_Application
{
    public partial class UserInterfaceForm : Form
    {
        string msg = "";
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }



        public UserInterfaceForm()
        {
            InitializeComponent();
        }

        private void UserInterfaceForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void SendMail(string complaint) {

            tbxComplaint.Clear();


            // ONLY Gmail accounts that have "Use LESS secure apps" ENABLED will work!!!!!
            try
            {
                var fromAddress = new MailAddress("Your email", "Your email name");
                var toAddress = new MailAddress("tenantcomplaints69@gmail.com", "Joseph Stalin");
                const string fromPassword = "Your password";
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


            } catch (Exception ex){
                MessageBox.Show(ex.ToString());
            }
        }

        private void TabPage2_Click(object sender, EventArgs e)
        {

        }

        private void UserInterfaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        private void BtnSendMail_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxComplaint.Text))
            {
                SendMail(tbxComplaint.Text);
            }
            else
            {
                MessageBox.Show("You need to enter a complaint!");
            }


        }

        private void TimerAnnouncement_Tick(object sender, EventArgs e)
        {
            lblAnnComplaints.Text = "";
            lblAnnChat.Text = "";
            lblAnnCalendar.Text = "";
            lblAnnScore.Text = "";
            timerAnnouncement.Enabled = false;
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

            lblAnnComplaints.Text = addmsg;
            lblAnnChat.Text = addmsg;
            lblAnnCalendar.Text = addmsg;
            lblAnnScore.Text = addmsg;
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            panelAnnChat.Visible = HidePanel(panelAnnChat.Visible);
        }

        private void BtnAnnCalendar_Click(object sender, EventArgs e)
        {
            panelAnnCalendar.Visible = HidePanel(panelAnnCalendar.Visible);
        }

        private void BtnAnnScore_Click(object sender, EventArgs e)
        {
            panelAnnScore.Visible = HidePanel(panelAnnScore.Visible);
        }

        string lblMsgs = "";
        private void BtnChatSend_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Today;
            string hour = dt.ToShortDateString();
            string current = tbxChatMsg.Text;
            tbxChat.Text =  $"{lblMsgs}[{hour}] Gosho:    {current} {Environment.NewLine}";
            lblMsgs = tbxChat.Text;
        }
    }
}
