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

        //Stores the ID of the landlord that currently logged in
        int personId;

        public LandLordForm(int personId)
        {
            InitializeComponent();

            this.personId = personId;
            UpdateLbxScore();
        }

        //Updates the lbx with the latest scores
        void UpdateLbxScore()
        {
            List<Account> accounts = db.GetAccountData();
            lbxScoreBoard.Items.Clear();
            foreach (Account a in accounts)
            {
                lbxScoreBoard.Items.Add($"{a.Name} - \t\t{a.Point}");
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
            else {
                MessageBox.Show("Enter an announcement!");
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
            NumericUpDown newish = new NumericUpDown();
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
    }
}
