using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenant_Application
{
    public partial class LandLordForm : Form
    {
        DataAccess db = new DataAccess();

        //New form objects for account managment
        RegistrationForm regForm;
        ModifyForm modForm;
        LoginForm loginForm; //Use the existing instance of this form

        int personId; //Stores the ID of the landlord that currently logged in
        string personName; //Stores his name

        public LandLordForm(int personId, LoginForm loginForm, string personName)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.personId = personId;
            this.personName = personName;
            this.loginForm = loginForm;
            db.SetOnline(this.personId, 1);
            regForm = new RegistrationForm(this);
            UpdateLbxScore();
        }

        //Updates the lbx with the latest scores
        public void UpdateLbxScore()
        {
            List<Account> accounts = db.GetAccountData();
            lbxScoreBoard.Items.Clear();
            foreach (Account a in accounts)
            {
                if(Helper.PopulateScoreBoard(a) != null)
                {
                    lbxScoreBoard.Items.Add(Helper.PopulateScoreBoard(a));
                }
            }
        }

        //Closes entire app
        private void LandLordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            bool close = Helper.LogOut(this.personId, this.db, this, loginForm, regForm, modForm); //Sets the user as OFFLINE
            if (!close)
            {
                e.Cancel = !close;
            }
        }


        //Sends an announcement to the db // Takes parameters such as date of the pc that sent it and the actual announcement
        private void BtnSend_Click(object sender, EventArgs e)
        {
            string announcement;
            if (!String.IsNullOrWhiteSpace(tbxAnnouncement.Text))
            {
                announcement = tbxAnnouncement.Text;
                try
                {
                    db.AddAnnouncement(announcement);
                    if(cbxAnnEmails.Checked)
                    {
                        MessageBox.Show(EmailForward.SendAnnToEveryMail(Helper.AllEmails(db), tbxAnnouncement.Text, "Announcement", "Successfully sent announcements"));
                    }
                    tbxAnnouncement.Text = "";
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                Helper.MsgBoxWarning("Enter an announcement!");
            }
        }

        //Logs out of the landlord form and goes back to the login form
        private void BtnAnnouncementLogout_Click(object sender, EventArgs e)
        {
            Helper.LogOut(this.personId, this.db, this, loginForm, regForm, modForm);
        }


        //Sets a new amount of points to the seletedperson from the listbox
        private void BtnAddPoint_Click(object sender, EventArgs e)
        {
            //personId = (string);
            string name = (string)lbxScoreBoard.SelectedItem; //SelectedAccount
            if (!string.IsNullOrEmpty(name) && !name.StartsWith("(+)") && !string.IsNullOrWhiteSpace(nudPoints.Text)) {

                Account a = Helper.ReturnAccountInfo(name, this.db);

                int points = a.Point;
                try
                {
                    points += Convert.ToInt32(nudPoints.Text);
                    if (points < 0) {
                        points = 0;
                    }
                    db.ChangePoints(points, a.id);
                    nudPoints.Text = "";
                    UpdateLbxScore();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                Helper.MsgBoxWarning("Select an tenant account and write down points");
            }
            
        }

        //Updates the listbox with all accounts
        public void UpdateAccounts()
        {
            lbxAccInfo.Items.Clear();
            List<Account> accounts = db.GetAccountData();
            for (int i = 0; i < accounts.Count; i++)
            {
                if(accounts[i].Admin == 1)
                {
                    lbxAccInfo.Items.Add($"{accounts[i].IdName} (Landlord)");
                }
                else
                {
                    lbxAccInfo.Items.Add(accounts[i].IdName);
                }
            }
        }

        //Whenever you select the account managment tab
        private void TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(tabControlLandlord.SelectedIndex == 2)
            {
                UpdateAccounts();
            }
        }

        //Deletes selected account
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (lbxAccInfo.SelectedIndex != -1)
            {
                string info = (string)lbxAccInfo.SelectedItem;
                if(info.Contains(this.personName))
                {
                    Helper.MsgBoxInformation("You can't delete your own account!");
                    
                }
                else
                {
                    DialogResult delete = MessageBox.Show("Are you sure you want to delete this account?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (delete == DialogResult.Yes)
                    {
                        List<Account> accounts = db.GetAccountData();
                        int selectedPersonId = 0;
                        foreach(Account a in accounts)
                        {
                            if(info.Contains(a.Name))
                            {
                                selectedPersonId = a.id;
                            }
                        }
                        db.DeleteAccount(selectedPersonId);
                        UpdateAccounts();
                        UpdateLbxScore();
                    }
                }
            }
        }

        //Modifies the information of the selected account - opens new form
        private void BtnModify_Click(object sender, EventArgs e)
        {
            if (lbxAccInfo.SelectedIndex != -1) //So it doesn't crash if nothing is selected
            {
                List<Account> accounts = db.GetAccountData();
                int index = lbxAccInfo.SelectedIndex;
                modForm = new ModifyForm(accounts[index], this, this.personId);
                modForm.Show();
                modForm.Focus();
            }
            else {
                MessageBox.Show("Select a person!");
            }
        }

        //Opens a form to create a new account
        private void BtnCreateAcc_Click(object sender, EventArgs e)
        {
            regForm.Show();
            regForm.Focus();
        }

        //Updates the accounts every 10 seconds
        private void TimerUpdateAccounts_Tick(object sender, EventArgs e)
        {
            UpdateAccounts();
        }

        //Manually resets the calendar
        private void BtnResetCalendar_Click(object sender, EventArgs e)
        {
            db.ResetCalendar();
        }

        //Manually resets the points of the tenants to 0
        private void btnResetPoints_Click(object sender, EventArgs e)
        {
            foreach (Account a in db.GetAccountData()) {
                if (a.Admin != 1) {
                    db.ChangePoints(0, a.id); //
                }
            }
            UpdateLbxScore();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Calendar c = new Calendar();
            Helper.CheckFormOpen(c);
        }

        private void btnSetOffline_Click(object sender, EventArgs e)
        {
            if (lbxAccInfo.SelectedIndex > -1)
            {
                List<Account> accountList = db.GetAccountData();
                int index = lbxAccInfo.SelectedIndex;

                int id = accountList[index].id;

                db.SetOnline(id, 0);

                MessageBox.Show("Succesfully performed task!");
            }
            else {
                MessageBox.Show("Select a person!");
            }
        }
    }
}
