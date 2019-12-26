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

        //Stores the ID of the landlord that currently logged in
        int personId;

        public LandLordForm(int personId)
        {
            InitializeComponent();

            this.personId = personId;
            UpdateLbxScore();
            //timerUpdateAccounts.Start();
        }

        //Updates the lbx with the latest scores
        public void UpdateLbxScore()
        {
            List<Account> accounts = db.GetAccountData();
            lbxScoreBoard.Items.Clear();
            foreach (Account a in accounts)
            {
                if(a.Admin == 1)
                {
                    lbxScoreBoard.Items.Add($"(+){a.Name} - \t\t{a.Point}");
                } 
                else
                {
                    lbxScoreBoard.Items.Add($"{a.Name} - \t\t{a.Point}");
                }
            }
        }

        private void LandLordForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
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
            string testing;
            if (!String.IsNullOrWhiteSpace(tbxAnnouncement.Text))
            {
                testing = tbxAnnouncement.Text;
                try
                {
                    db.AddAnnouncement(DateTime.Today.ToString("d"), testing);
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
                LoginForm loginF = new LoginForm();
                loginF.Show();
                this.Hide();
            }
        }


        //Sets a new amount of points to the seletedperson from the listbox
        private void BtnAddPoint_Click(object sender, EventArgs e)
        {
            int id = lbxScoreBoard.SelectedIndex + 1;
            string selected = (string)lbxScoreBoard.SelectedItem;
            NumericUpDown newish = new NumericUpDown();
            if (lbxScoreBoard.SelectedIndex != -1 && !string.IsNullOrWhiteSpace(tbxPoint.Text))
            {
                if (!selected.StartsWith("DELETED") && !selected.StartsWith("(+)"))
                {
                    try
                    {
                        db.ChangePoints(Convert.ToInt32(tbxPoint.Text), id);
                        tbxPoint.Text = "";
                        UpdateLbxScore();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.ToString());
                    }
                }
                else
                {
                    MsgBoxWarning("You can't add points to a deleted or landlord account");
                }
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
            if(lbxAccInfo.SelectedIndex != -1)
            {
                DialogResult delete = MessageBox.Show("Are you sure you want to delete this account?", "Delete Account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (delete == DialogResult.Yes)
                {
                    //Still a concept, hard to achieve properly because of ID primary/foreign key missmatch
                    List<Account> accounts = db.GetAccountData();
                    int index = lbxAccInfo.SelectedIndex;
                    db.DeleteAccount(accounts[index].id);
                    UpdateAccounts();
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
                modForm = new ModifyForm(accounts[index], this);
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
    }
}
