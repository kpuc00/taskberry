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

        public UserInterfaceForm(int personId, string personEmail, string personPassword)
        {
            InitializeComponent();

            //Get data passed from login screen
            this.personId = personId;
            this.personEmail = personEmail;
            this.personPassword = personPassword;

            
            timerAnnDisp.Start(); //Displays new announcements
        }

        private void UserInterfaceForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
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
            if (db.GetAnnouncements().Count != lastLength)
            {
                lastLength = db.GetAnnouncements().Count;

                string ann = db.GetAnnouncements()[db.GetAnnouncements().Count - 1].Date + db.GetAnnouncements()[db.GetAnnouncements().Count - 1].Annoucement;

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

            try
            {
                List<Announcement> listAnn = db.GetAnnouncements();

                RstAnnPanel(); //Clear the panel

                //Add the announcements to the announcement panel
                string storeText = "";
                foreach (Announcement a in listAnn)
                {
                    storeText += a.Date + a.Annoucement + Environment.NewLine;
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


        //Custom messagebox
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
