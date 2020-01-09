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
            UpdateLbxScore();
        }

        //Updates the lbx with the latest scores
        public void UpdateLbxScore()
        {
            List<Account> accounts = db.GetAccountData();
            lbxScoreBoard.Items.Clear();
            foreach (Account a in accounts)
            {
                if(a.Admin == 1) //Landlordd account = 1, NORMAL account = 0
                {
                    lbxScoreBoard.Items.Add($"(+){a.Name} - \t\t{a.Point}");
                } 
                else
                {
                    lbxScoreBoard.Items.Add($"{a.Name} - \t\t{a.Point}");
                }
            }
        }

        //Closes entire app
        private void LandLordForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.ExitThread();
            Application.Exit();
        }

        //closes entire app
        private void LandLordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(-1);
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
                    db.AddAnnouncement(DateTime.Today.ToString("d"), announcement);
                    tbxAnnouncement.Text = "";
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MsgBoxWarning("Enter an announcement!");
            }
        }

        //Logs out of the landlord form and goes back to the login form
        private void BtnAnnouncementLogout_Click(object sender, EventArgs e)
        {
            DialogResult logout = MessageBox.Show("Are u sure u want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (logout == DialogResult.Yes)
            {
                loginForm.Show();
                this.Hide();
                this.Dispose();
            }
        }


        //Sets a new amount of points to the seletedperson from the listbox
        private void BtnAddPoint_Click(object sender, EventArgs e)
        {
            string selected = (string)lbxScoreBoard.SelectedItem; //SelectedAccount
            int points = 0;
            List<Account> accounts = db.GetAccountData();
            int theId = 0; //Id of selected account
            foreach (Account a in accounts)
            {
                if (selected.Contains(a.Name))
                {
                    points = a.Point;
                    theId = a.id;
                    break;
                }
            }
            accounts.Clear();

            if (lbxScoreBoard.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(nudPoints.Text))
            {
                if (!selected.StartsWith("(+)"))
                {
                    try
                    {
                        points += Convert.ToInt32(nudPoints.Text);
                        db.ChangePoints(points, theId);
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
                    MsgBoxWarning("You can't add points to a landlord account");
                }
            }
            else
            {
                MsgBoxWarning("Select an account and write down points");
            }
        }

        //Custom messageboxes
        public void MsgBoxWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void MsgBoxInformation(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("You can't delete your own account!");
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
        }

        //Opens a form to create a new account
        private void BtnCreateAcc_Click(object sender, EventArgs e)
        {
            regForm = new RegistrationForm(this);
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
    }
}
