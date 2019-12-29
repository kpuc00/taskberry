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
        string personName;

        //Memory fix
        //Use the existing instance of this form
        LoginForm loginForm;

        //Moved the email to a class so we can use it everywhere
        EmailForward newEmail = new EmailForward();

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

        public UserInterfaceForm(int personId, string personEmail, string personPassword, string personName, LoginForm loginForm)
        {
            InitializeComponent();

            //Get data passed from login screen
            this.personId = personId;
            this.personEmail = personEmail;
            this.personPassword = personPassword;
            this.personName = personName;
            this.loginForm = loginForm;
            db.SetOnline(personId, 1);
            timerOnline.Start();

            
            timerAnnDisp.Start(); //Displays new announcements
        }

        private void UserInterfaceForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            UpdateLbxScore();
            ListWeekdays();
            timerScoreboard.Enabled = true;
            lblChatMain.Text = $"{personName}, welcome to the chat room";
        }

        //Listbox of calendar: Shows the days of the week
        void ListWeekdays()
        {
            CalendarDays days = new CalendarDays();
            foreach(string d in days.ShowDays())
            {
                lbxCalendarDays.Items.Add(d);
            }
        }

        //Closes entire app
        private void UserInterfaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        //Closes entire app



        private void SendMail(string complaint)
        {
            tbxComplaint.Clear();
            string sucessful = "Thank you for contacting us. We will review your complaint, and get back to you as soon as possible!";
            MsgBoxInformation(newEmail.SendMail(personEmail, personPassword, complaint, "Complaint", sucessful));
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

        //Updates scoreboard listbox: Fetches the data from the DB
        void UpdateLbxScore()
        {
            List<Account> accounts = db.GetAccountData();
            lbxScoreboard.Items.Clear();
            foreach (Account a in accounts)
            {
                if (a.Name != "DELETED" && a.Admin != 1)
                {
                    lbxScoreboard.Items.Add($"{a.Name} - \t\t{a.Point}");
                }
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
                    if (msg != "")
                    {
                        msg = ann.Substring(0, 30);
                        msg += " ...";
                    }
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

        //Logout button functionality
        private void BtnComplaintLogout_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Are u sure u want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (logout == DialogResult.Yes)
            {
                db.SetOnline(personId, 0);
                //LoginForm loginF = new LoginForm();
                loginForm.Show();
                this.Hide();
                this.Dispose();
            }
        }

        //timer for interval between pulling scoreboard info
        private void TimerScoreboard_Tick(object sender, EventArgs e)
        {
            UpdateLbxScore();
        }

        //Pulls calendar information: If a chore is "taken" - it's already been taken by someone; it ain't shown in the lbx
        public void UpdateChoresLbx()
        {
            List<CalendarDays> days = db.GetCalendar();
            string item = lbxCalendarDays.SelectedItem.ToString();

            try
            {
                switch (item)
                {
                    case "Tuesday":
                        lbxCalendarChores.Items.Clear();
                        foreach (CalendarDays a in days)
                        {
                            if (a.Tuesday != "0")
                            {
                                lbxCalendarChores.Items.Add(a.Tuesday.Substring(1));
                            }
                        }
                        break;
                    case "Wednesday":
                        lbxCalendarChores.Items.Clear();
                        foreach (CalendarDays a in days)
                        {
                            if (a.Wednesday != "0")
                            {
                                lbxCalendarChores.Items.Add(a.Wednesday.Substring(1));
                            }
                        }
                        break;
                    case "Thursday":
                        lbxCalendarChores.Items.Clear();
                        foreach (CalendarDays a in days)
                        {
                            if (a.Thursday != "0")
                            {
                                lbxCalendarChores.Items.Add(a.Thursday.Substring(1));
                            }
                        }
                        break;
                    case "Friday":
                        lbxCalendarChores.Items.Clear();
                        foreach (CalendarDays a in days)
                        {
                            if (a.Friday != "0")
                            {
                                lbxCalendarChores.Items.Add(a.Friday.Substring(1));
                            }
                        }
                        break;
                    case "Saturday":
                        lbxCalendarChores.Items.Clear();
                        foreach (CalendarDays a in days)
                        {
                            if (a.Saturday != "0")
                            {
                                lbxCalendarChores.Items.Add(a.Saturday.Substring(1));
                            }
                        }
                        break;
                    case "Sunday":
                        lbxCalendarChores.Items.Clear();
                        foreach (CalendarDays a in days)
                        {
                            if (a.Sunday != "0")
                            {
                                lbxCalendarChores.Items.Add(a.Sunday.Substring(1));
                            }
                        }
                        break;
                    default:
                        lbxCalendarChores.Items.Clear();
                        foreach (CalendarDays day in days)
                        {
                            if (day.Monday != "0")
                            {
                                lbxCalendarChores.Items.Add(day.Monday.Substring(1));
                            }
                        }
                        break;
                }
            }
            catch (Exception ec)
            {
                MessageBox.Show(ec.ToString());
            }
        }

        //Communicates with the db - sends the selectedchore and the DB places a 0 in its place - when the data from the DB
        //is called again - the lbx ignores the 0; So people can only select NON-TAKEN chores
        private void BtnCalendarSelect_Click(object sender, EventArgs e)
        {
            try
            {
                string chore = "0" + lbxCalendarChores.SelectedItem.ToString();
                db.UpdateCalendarChores(lbxCalendarDays.SelectedItem.ToString(), chore);
                string selChore = lbxCalendarChores.SelectedItem.ToString();
                List<Account> accounts = db.GetAccountData();
                int points = 0;

                for(int i = 0; i < accounts.Count; i++)
                {
                    if(accounts[i].id == personId)
                    {
                        points = accounts[i].Point;
                    }
                }
                switch (selChore)
                {
                    case "Throw Thrash":
                        db.ChangePoints(points + 2, personId);
                        break;
                    case "Wash Dishes":
                        db.ChangePoints(points + 5, personId);
                        break;
                    case "Vacuum Floor":
                        db.ChangePoints(points + 4, personId);
                        break;
                    case "Mop Floor":
                        db.ChangePoints(points + 4, personId);
                        break;
                    case "Shop Misc":
                        db.ChangePoints(points + 3, personId);
                        break;
                }
                UpdateChoresLbx();
                UpdateLbxScore();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            //db.SetCalendar("Wednesday", "3Wash Dishes");
        }

        //Sets current chores for the selected day that are available
        private void LbxCalendarDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChoresLbx();
        }

        private void TimerOnline_Tick(object sender, EventArgs e)
        {
            lbxOnlineUsers.Items.Clear();
            List<Account> accounts = db.GetAccountData();
            foreach (Account a in accounts)
            {
                if (a.Online == 1)
                {
                    lbxOnlineUsers.Items.Add(a.Name);
                }
            }
        }
    }
}
