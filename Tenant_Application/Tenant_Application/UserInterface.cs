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

        //Memory Fix. Use the existing instance of this form
        LoginForm loginForm;

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
            db.SetOnline(personId, 1);                          //Sets the account as Online
            UpdateChat();                                       //Update the chat on login
            timerAnnDisp.Start();                               //Displays new announcements
            timerAnnouncement.Start();
            this.FormBorderStyle = FormBorderStyle.FixedDialog; //No user resizing
            UpdateLbxScore();                                   //Updates the scoreboard
            ListWeekdays();                                     //Lists all of the weekdays in the calendar
            timerChatScoreboard.Enabled = true;                 //Timer for updating chat related methods every X seconds
            lblChatMain.Text = $"{personName}, welcome to the chat room"; //Updates the chat welcome message
        }

        //Listbox of calendar: Shows the days of the week
        void ListWeekdays()
        {
            CalendarDay days = new CalendarDay();
            foreach (string d in days.DisplayDays())
            {
                lbxCalendarDays.Items.Add(d);
            }
        }

        //Closes entire app
        private void UserInterfaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool close = Helper.LogOut(this.personId, this.db, this, loginForm); //Sets the user as OFFLINE

            if (!close)
            {
                e.Cancel = !close; //Close is candeled 
            }
        }

        //Sending complaints 
        private void BtnSendMail_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(tbxComplaint.Text))
            {
                string sucessful = "Thank you for contacting us. We will review your complaint, and get back to you as soon as possible!";
                Helper.MsgBoxInformation(EmailForward.SendMail(tbxComplaint.Text, "Complaint", sucessful)); //Forwards this to an object
                tbxComplaint.Clear();
            }
            else
            {
                Helper.MsgBoxWarning("You need to enter a complaint!");
            }
        }

        //Updates scoreboard listbox: Fetches the data from the DB
        void UpdateLbxScore()
        {
            List<Account> accounts = db.GetAccountData();
            lbxScoreboard.Items.Clear();
            foreach (Account a in accounts)
            {
                if (Helper.PopulateScoreBoard(a) != null)
                {
                    lbxScoreboard.Items.Add(Helper.PopulateScoreBoard(a));
                }
            }
        }

        /*Handle Announcement*/

        int lastLength = 0; //Keeps track if new announcemment is added

        //Disp new announcement as pop-up
        private void TimerAnnDisp_Tick(object sender, EventArgs e)
        {

            if (db.GetAnnouncements().Count != lastLength) //Checks if new announcement is added
            {
                var announcements = db.GetAnnouncements();
                string msg = "";
                lastLength = announcements.Count; //Gets the new amount of announcements

                //Gets the last announcement in the data base
                string ann = $"{announcements[announcements.Count - 1].Date}: {announcements[announcements.Count - 1].Testing}";

                //Show only the 20 first characters
                if (ann.Length > 20)
                {
                    msg = ann.Substring(0, 20);
                    msg += " ...";
                }

                AnnLabelHandling(msg); //Show the announcement
            }
        }

        //Rmv new announcement as pop-up
        private void TimerAnnouncement_Tick(object sender, EventArgs e)
        {
            AnnLabelHandling("");
        }

        //Populates the pop-up label for announcements acording to the paramenter
        private void AnnLabelHandling(string text)
        {
            lblAnnComplaints.Text = text;
            lblAnnChat.Text = text;
            lblAnnCalendar.Text = text;
            lblAnnScore.Text = text;
        }

        //Open/Close the announcememnt panel
        private void BtnAnnCalendar_Click(object sender, EventArgs e)
        {
            panelAnnCalendar.Visible = !panelAnnCalendar.Visible;
            panelAnnChat.Visible = !panelAnnChat.Visible;
            panelAnnComplaints.Visible = !panelAnnComplaints.Visible;
            panelAnnScore.Visible = !panelAnnScore.Visible;

            try
            {
                List<Announcement> listAnn = db.GetAnnouncements(); //Get all the announcements
                listAnn.Reverse();
                ResetAnnouncementPanel(); //Clear the panel

                //Add the announcements to the announcement panel
                string storeText = "";
                foreach (Announcement a in listAnn)
                {
                    string s = formatAnn(a.Testing);
                    storeText = a.Date + ": " + s;
                    ListBoxesPopulate(storeText); //Add the announcement to the announcement panel
                }
            }
            catch (Exception ex)
            {
                Helper.MsgBoxWarning(ex.ToString());
            }
        }

        private string formatAnn(string ann)
        {
            string[] words = ann.Split(' ');
            string retVal = "";

            if (words[words.Length - 1] == "\n")
            {
                words[words.Length - 1] = "";
            }

            for (int i = 0; i < words.Length; i++)
            {
                if (i % 7 == 0)
                {
                    retVal += "\n";
                }
                retVal += words[i] + " ";
            }
            return retVal + "\t" + "\n\n";
        }

        /*End Handle Announcement*/

        //Adds the announcement on top one of another
        public void ListBoxesPopulate(string text)
        {
            tbxAnnCalendar.Text += text;
            tbxAnnCR.Text += text;
            tbxAnnScore.Text += text;
            tbxAnnCom.Text += text;
        }

        //Empty the announcement panel
        private void ResetAnnouncementPanel()
        {
            tbxAnnCalendar.Text = "";
            tbxAnnCR.Text = "";
            tbxAnnScore.Text = "";
            tbxAnnCom.Text = "";
        }

        //Closes the announcement panel on all tabs
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
            Helper.LogOut(this.personId, this.db, this, loginForm);
        }

        //Timer for updating scoreboard info
        private void TimerScoreboard_Tick(object sender, EventArgs e)
        {
            UpdateLbxScore();
            UpdateChat();
        }

        //Pulls calendar information: If a chore is "taken" - it's already been taken by someone; it ain't shown in the lbx
        public void UpdateChoresLbx()
        {
            List<CalendarDay> days = db.GetCalendar();
            string item = lbxCalendarDays.SelectedItem.ToString();
            lbxCalendarChores.Items.Clear();

            void f(Func<CalendarDay, string> getDay)
            {
                foreach (CalendarDay a in days)
                {
                    string day = getDay(a);
                    bool flag = false;

                    for (int i = 0; i < 7; i++)
                        if (day.StartsWith(i.ToString()))
                            flag = true;

                    if (flag)
                        lbxCalendarChores.Items.Add(a.Tuesday.Substring(1));
                }
            }

            try
            {
                switch (item)
                {
                    case "Tuesday":
                        f(calendarDay => calendarDay.Tuesday);
                        break;
                    case "Wednesday":
                        f(calendarDay => calendarDay.Wednesday);
                        break;
                    case "Thursday":
                        f(calendarDay => calendarDay.Thursday);
                        break;
                    case "Friday":
                        f(calendarDay => calendarDay.Friday);
                        break;
                    case "Saturday":
                        f(calendarDay => calendarDay.Saturday);
                        break;
                    case "Sunday":
                        f(calendarDay => calendarDay.Sunday);
                        break;
                    default:
                        f(calendarDay => calendarDay.Monday);
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
                //In the database - days have a unique Identifier, 0-Monday, 1-Tuesday etc.
                //thats why whenever the selected item is a day - it needs to send its unique identifier 
                string s = lbxCalendarDays.SelectedIndex.ToString();
                //Sends
                string chore = s + lbxCalendarChores.SelectedItem.ToString();
                db.UpdateCalendarChores(lbxCalendarDays.SelectedItem.ToString(), chore, this.personName);
                string selChore = lbxCalendarChores.SelectedItem.ToString();
                List<Account> accounts = db.GetAccountData();
                int points = 0;

                for (int i = 0; i < accounts.Count; i++)
                {
                    if (accounts[i].id == personId)
                    {
                        points = accounts[i].Point;
                    }
                }
                switch (selChore)
                {
                    case "Throw Trash":
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
            catch (Exception)
            {
                Helper.MsgBoxWarning("Please select a chore!");
            }
        }

        //Sets current chores for the selected day that are available
        private void LbxCalendarDays_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateChoresLbx();
        }

        //Sends the chat message to the db
        private void BtnChatSend_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxChatMsg.Text))
            {
                //do nothing
            }
            else
            {
                //send the message
                string msg = tbxChatMsg.Text;
                db.SendChat(msg, personId);
                UpdateChat();
                tbxChatMsg.Text = null;
            }
        }
        string last = "";

        //Updates the chat with the last 20 messages
        void UpdateChat()
        {
            lbxOnlineUsers.Items.Clear();
            List<Account> accounts = db.GetAccountData();
            foreach (Account a in accounts)
            {
                if (a.Online == 1 && a.Admin == 0) //If user online
                {
                    lbxOnlineUsers.Items.Add(a.Name); //Shows user in chat
                }
            }
            //Have to find a way to save the messages inside a list inside 1 OBJECT, atm there are 20 objects (each msg is an object)
            //You can't directly save msgs inside a list inside an object, a loop maybe
            string previousMsg = ""; //Saves previous messages
            List<Chat> chats = db.GetChat();

            if (chats != null)
            {
                if (chats[0].Message != last)
                {
                    for (int i = chats.Count - 1; i > 0; i--) //It's reversed because i order by descending ID in the db
                    {
                        previousMsg += $"[{chats[i - 1].Date}] [{chats[i - 1].Name}] \t {chats[i - 1].Message} {Environment.NewLine}";
                        tbxChat.Text = previousMsg;
                    }
                    last = chats[0].Message;
                    tbxChat.SelectionStart = tbxChat.Text.Length;
                    tbxChat.ScrollToCaret();
                }
            }

            //Alowes to send message only when you have writen text
            if (string.IsNullOrWhiteSpace(tbxChatMsg.Text))
            {
                btnChatSend.Enabled = false;
            }
            else
            {
                btnChatSend.Enabled = true;
            }
        }


        private void tbxChatMsg_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnChatSend_Click(this, new EventArgs());
            }
        }

        private void btnOpenCalendar_Click(object sender, EventArgs e)
        {
            Calendar c = new Calendar();
            Helper.ShowCalendarIfNotOpen(c);
        }
    }

}
