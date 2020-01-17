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
            CalendarDays days = new CalendarDays();
            foreach (string d in days.ShowDays())
            {
                lbxCalendarDays.Items.Add(d);
            }
        }

        //Closes entire app
        private void UserInterfaceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool close = Helper.LogOut(this.personId, this.db, this); //Sets the user as OFFLINE

            if (!close)
            {
                e.Cancel = !close; //Close is candeled 
            }
            else {
                //Exit normaly
                Application.ExitThread();
                Application.Exit();
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
                string msg = "";
                lastLength = db.GetAnnouncements().Count; //Gets the new amount of announcements

                //Gets the last announcement in the data base
                string ann = $"{db.GetAnnouncements()[db.GetAnnouncements().Count - 1].Date}: {db.GetAnnouncements()[db.GetAnnouncements().Count - 1].Testing}"; 

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
        private void AnnLabelHandling(string text) {
            lblAnnComplaints.Text = text;
            lblAnnChat.Text = text;
            lblAnnCalendar.Text = text;
            lblAnnScore.Text = text;
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
                List<Announcement> listAnn = db.GetAnnouncements(); //Get all the announcements
                listAnn.Reverse();
                RstAnnPanel(); //Clear the panel

                //Add the announcements to the announcement panel
                string storeText = "";
                foreach (Announcement a in listAnn)
                {
                    string s = formatAnn(a.Testing);
                    storeText = a.Date + ": "  + s;
                    ListBoxesPopulate(storeText); //Add the announcement to the announcement panel
                }
            }
            catch (Exception ex)
            {
                Helper.MsgBoxWarning(ex.ToString());
            }
        }

        private string formatAnn(string ann) {
            string[] words = ann.Split(' ');
            string retVal = "";

            if (words[words.Length - 1] == "\n") {
                words[words.Length - 1] = "";
            }

            for (int i = 0; i < words.Length; i++) {
                if (i % 7 == 0) {
                    retVal += "\n"; 
                }
                retVal += words[i] + " ";
            }
            return retVal + "\t" +"\n\n"; 
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
        private void RstAnnPanel()
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
                            if (a.Tuesday.StartsWith("0") || a.Tuesday.StartsWith("1") || a.Tuesday.StartsWith("2") || a.Tuesday.StartsWith("3") ||
                                a.Tuesday.StartsWith("4") || a.Tuesday.StartsWith("5") || a.Tuesday.StartsWith("6"))
                            {
                                lbxCalendarChores.Items.Add(a.Tuesday.Substring(1));
                            }
                        }
                        break;
                    case "Wednesday":
                        lbxCalendarChores.Items.Clear();
                        foreach (CalendarDays a in days)
                        {
                            if (a.Wednesday.StartsWith("0") || a.Wednesday.StartsWith("1") || a.Wednesday.StartsWith("2") || a.Wednesday.StartsWith("3") ||
                                a.Wednesday.StartsWith("4") || a.Wednesday.StartsWith("5") || a.Wednesday.StartsWith("6"))
                            {
                                lbxCalendarChores.Items.Add(a.Wednesday.Substring(1));
                            }
                        }
                        break;
                    case "Thursday":
                        lbxCalendarChores.Items.Clear();
                        foreach (CalendarDays a in days)
                        {
                            if (a.Thursday.StartsWith("0") || a.Thursday.StartsWith("1") || a.Thursday.StartsWith("2") || a.Thursday.StartsWith("3") ||
                                a.Thursday.StartsWith("4") || a.Thursday.StartsWith("5") || a.Thursday.StartsWith("6"))
                            {
                                lbxCalendarChores.Items.Add(a.Thursday.Substring(1));
                            }
                        }
                        break;
                    case "Friday":
                        lbxCalendarChores.Items.Clear();
                        foreach (CalendarDays a in days)
                        {
                            if (a.Friday.StartsWith("0") || a.Friday.StartsWith("1") || a.Friday.StartsWith("2") || a.Friday.StartsWith("3") ||
                                a.Friday.StartsWith("4") || a.Friday.StartsWith("5") || a.Friday.StartsWith("6"))
                            {
                                lbxCalendarChores.Items.Add(a.Friday.Substring(1));
                            }
                        }
                        break;
                    case "Saturday":
                        lbxCalendarChores.Items.Clear();
                        foreach (CalendarDays a in days)
                        {
                            if (a.Saturday.StartsWith("0") || a.Saturday.StartsWith("1") || a.Saturday.StartsWith("2") || a.Saturday.StartsWith("3") ||
                                a.Saturday.StartsWith("4") || a.Saturday.StartsWith("5") || a.Saturday.StartsWith("6"))
                            {
                                lbxCalendarChores.Items.Add(a.Saturday.Substring(1));
                            }
                        }
                        break;
                    case "Sunday":
                        lbxCalendarChores.Items.Clear();
                        foreach (CalendarDays a in days)
                        {
                            if (a.Sunday.StartsWith("0") || a.Sunday.StartsWith("1") || a.Sunday.StartsWith("2") || a.Sunday.StartsWith("3") ||
                                a.Sunday.StartsWith("4") || a.Sunday.StartsWith("5") || a.Sunday.StartsWith("6"))
                            {
                                lbxCalendarChores.Items.Add(a.Sunday.Substring(1));
                            }
                        }
                        break;
                    default:
                        lbxCalendarChores.Items.Clear();
                        foreach (CalendarDays day in days)
                        {
                            if (day.Monday.StartsWith("0") || day.Monday.StartsWith("1") || day.Monday.StartsWith("2") || day.Monday.StartsWith("3") ||
                                day.Monday.StartsWith("4") || day.Monday.StartsWith("5") || day.Monday.StartsWith("6"))
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
                //In the database - days have a unique Identifier, 0-Monday, 1-Tuesday etc.
                //thats why whenever the selected item is a day - it needs to send its unique identifier 
                string  s = lbxCalendarDays.SelectedIndex.ToString();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
            List<ChatDB> chats = db.GetChat();

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
            Calendar calendar = new Calendar();
            calendar.Show();
        }
    }

}
