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

        int personId;

        public LandLordForm(int personId)
        {
            InitializeComponent();

            this.personId = personId;
            UpdateLbxScore();
        }

        void UpdateLbxScore()
        {
            List<Account> accounts = db.GetPoints();
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

        private void BtnAddPoint_Click(object sender, EventArgs e)
        {
            //lbx.count - 1
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
