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
            UpdateLbxScore();
            timerScoreboard.Enabled = true;
        }

        void UpdateChores()
        {
            try
            {
                List<Chore> availableChores = db.GetEmptyChores(1, 2);
                lbxCalendarChores.Items.Clear();
                lbxCalendarDays.Items.Clear();
                foreach (Chore c in availableChores)
                {
                    lbxCalendarDays.Items.Add(c.Day);
                    lbxCalendarChores.Items.Add($"{c.Chores} - {c.Name}");
                }
            }
            catch(Exception ecc)
            {
                MessageBox.Show(ecc.ToString());
            }
        }

        //Closes entire app
        private void UserInterfaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        //Closes entire app



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

                MsgBoxInformation("Thank you for your contacting us. We will review your complaint, and get back to you as soon as possible!");
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

        void UpdateLbxScore()
        {
            List<Account> accounts = db.GetPoints();
            lbxScoreboard.Items.Clear();
            foreach (Account a in accounts)
            {
                lbxScoreboard.Items.Add($"{a.Name} - \t\t{a.Point}");
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

                string ann = $"{db.GetAnnouncements()[db.GetAnnouncements().Count - 1].Date} - {db.GetAnnouncements()[db.GetAnnouncements().Count - 1].Testing}";

                if (ann.Length > 20)
                {
                    //at 30th character - ...
                    msg = ann.Substring(0, 30);
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
                List<Announcement> listAnn = db.GetAnnouncements();

                RstAnnPanel(); //Clear the panel

                //Add the announcements to the announcement panel
                string storeText = "";
                foreach (Announcement a in listAnn)
                {
                    storeText += $"{a.Date} - {a.Testing }{Environment.NewLine}";
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

        private void TabSwitch_SelectedIndexChanged(object sender, EventArgs e)
        {
            panelAnnScore.Visible = false;
            panelAnnCalendar.Visible = false;
            panelAnnComplaints.Visible = false;
            panelAnnChat.Visible = false;
        }

        private void BtnComplaintLogout_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Are u sure u want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (logout == DialogResult.Yes)
            {
                LoginForm loginF = new LoginForm();
                loginF.Show();
                this.Hide();
            }
        }

        private void TimerScoreboard_Tick(object sender, EventArgs e)
        {
            UpdateLbxScore();
        }


        void TestingUpdate()
        {
            try
            {
                List<CalendarDays> days = db.CalendarMonday();
                lbxScoreboard.Items.Clear();
                foreach (CalendarDays a in days)
                {
                    if (a.Monday != "0")
                    {
                        lbxCalendarChores.Items.Add(a.Monday.Substring(1));
                    }
                    if (a.Tuesday != "0")
                    {
                        lbxCalendarChores.Items.Add(a.Tuesday.Substring(1));
                    }
                    if (a.Wednesday != "0")
                    {
                        lbxCalendarChores.Items.Add(a.Wednesday.Substring(1));
                    }
                    if (a.Thursday != "0")
                    {
                        lbxCalendarChores.Items.Add(a.Thursday.Substring(1));
                    }
                    if (a.Friday != "0")
                    {
                        lbxCalendarChores.Items.Add(a.Friday.Substring(1));
                    }
                    if (a.Saturday != "0")
                    {
                        lbxCalendarChores.Items.Add(a.Saturday.Substring(1));
                    }
                    if (a.Sunday != "0")
                    {
                        lbxCalendarChores.Items.Add(a.Sunday.Substring(1));
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        
        private void BtnCalendarSelect_Click(object sender, EventArgs e)
        {
            //UpdateChores();
            //TestingUpdate();

            try
            {
                db.SetCalendar("Thursday", "3Mop Floor");
                MessageBox.Show("It worked?");
                TestingUpdate();
            }
            catch(Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }
    }
}
