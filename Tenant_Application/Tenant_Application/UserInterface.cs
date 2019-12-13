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


        //Holding personal information
        int personId;
        string personEmail;
        string personUsername;
        string personPassword;

        //Overried some painter settings - makes form load faster
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;  // Turn on WS_EX_COMPOSITED //cause that makes sense ~ by Michael_gvdw //it actually helps a bit - this + doublebuffering
                return cp;
            }
        }

        //Create an object of the class WebSocket
        WebSocket ws;

        public UserInterfaceForm(int personId, string personEmail, string personUsername, string personPassword)
        {
            InitializeComponent();

            //Get data passed from login screen
            this.personId = personId;
            this.personEmail = personEmail;
            this.personUsername = personUsername;
            this.personPassword = personPassword;

            ws = new WebSocket();

            timerAnnDisp.Start(); //Displays new announcements
        }

        private void UserInterfaceForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            timerRefreshScoreBoard.Start();

            //get user ip
            //string localIp = ws.GetLocalIP();
            InitializeChatConnection();
            lbxOnlineUsers.Items.Add(this.personUsername);
            timerChatListBox.Start();
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

        //Hides or shows announcement panel
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
                        /*Handle Announcement*/

        int lastLength = 0; //Keeps track if new announcemment is added
        string msg = "";
        //Disp new announcement as pop-up
        private void TimerAnnDisp_Tick(object sender, EventArgs e)
        {
            if (db.GetAnnouncement().Count != lastLength)
            {
                lastLength = db.GetAnnouncement().Count;

                string ann = db.GetDate()[db.GetDate().Count - 1].Date + ": " +db.GetAnnouncement()[db.GetAnnouncement().Count - 1].Annoucement;

                if (ann.Length > 20)
                {
                    //at 20th character - ...
                    msg = ann.Substring(0, 20);
                    msg += " ...";
                }

                lblAnnComplaints.Text = msg;
                lblAnnChat.Text = msg;
                lblAnnCalendar.Text = msg;
                lblAnnScore.Text = msg;

                timerAnnouncement.Start();
            }
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
            panelAnnChat.Visible = HidePanel(panelAnnChat.Visible);
            panelAnnComplaints.Visible = HidePanel(panelAnnComplaints.Visible);
            panelAnnScore.Visible = HidePanel(panelAnnScore.Visible);

            try
            {
                List<Announcement> listAnn = db.GetAnnouncement();
                List<Announcement> listDate = db.GetDate();

                RstAnnPanel(); //Clear the panel

                //Add the announcements to the announcement panel
                string storeText = "";
                for (int i = 0; i < listAnn.Count; i++) {
                    storeText += listDate[i].Date + listAnn[i].Annoucement + Environment.NewLine;
                }

                tbxAnnChat.Text = storeText;
                tbxAnnComplaints.Text = storeText;
                tbxAnnCalendar.Text = storeText;
                tbxAnnScore.Text = storeText;
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

        private void TimerRefreshScoreBoard_Tick(object sender, EventArgs e)
        {
            lbxScoreboard.Items.Clear();

            List<Points> nameList = db.GetNames();
            List<Points> pointList = db.GetPoints();

            for (int j = 0; j < pointList.Count; j++)
            {
                lbxScoreboard.Items.Add(nameList[j].Name + ": " +pointList[j].Point);
            }
        }

        //Custom messagebox
        public void MsgBoxWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void MsgBoxInformation(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //Code for the chat
        string localip = "192.168.43.59";
        string localport = "55555";

        string user2ip = "192.168.43.111";
        string user2port = "55555";

        private void InitializeChatConnection()
        {
            try
            {
                ws.connect(localip, localport, user2ip, user2port);
                lblChatConnection.Text = "Connection status: Connected";
            }
            catch
            {
                lblChatConnection.Text = "Connection status: Not connected";
            }
        }

        private void BtnChatSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxChatMsg.Text))
            {
                //do nothing 
            }
            else
            {
                //send the msg
                ws.sendMsg(this.personUsername + ":" + " " + tbxChatMsg.Text);
                tbxChatMsg.Text = "";
            }
        }

        private void TimerChatListBox_Tick(object sender, EventArgs e)
        {
            lbxChat.Items.Clear();
            foreach (var item in ws.messages)
            {
                lbxChat.Items.Add(item);
            }
        }
    }
}
