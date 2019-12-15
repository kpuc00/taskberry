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
        }

        private void LandLordForm_Load(object sender, EventArgs e)
        {
            timerRefreshScoreBoard.Start();
            //this.FormBorderStyle = FormBorderStyle.FixedDialog;
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
            string announcement;
            if (!String.IsNullOrWhiteSpace(tbxAnnouncement.Text))
            {
                announcement = tbxAnnouncement.Text;
                try
                {
                    db.AddAnnouncement(announcement, DateTime.Now.ToString());
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
            else {
                MessageBox.Show("Enter an announcement!");
            }
            
            
        }

        private void TimerRefreshScoreBoard_Tick(object sender, EventArgs e)
        {
            lbxScoreBoard.Items.Clear();

            List<Account> pointList = db.GetPoints();
            string nameList = db.GetAccountByName();

            for (int i = 0; i < pointList.Count; i++) {
                lbxScoreBoard.Items.Add(nameList + ": " + pointList[i].ToString());
            }
        }

        private void BtnAddPoint_Click(object sender, EventArgs e)
        {
            string name = NameTenant();

            if (name != null)
            {
                int id = db.GetIdByName(name);

                if (!String.IsNullOrWhiteSpace(tbxPoint.Text))
                {
                    db.ChangePoints(Convert.ToInt32(tbxPoint.Text), id);
                }
            }
        }

        private void BtnRmvPoint_Click(object sender, EventArgs e)
        {
            string name = NameTenant();

            if (name != null)
            {
                int id = db.GetIdByName(name);

                if (!String.IsNullOrWhiteSpace(tbxPoint.Text))
                {
                    db.ChangePoints(-Convert.ToInt32(tbxPoint.Text), id);
                }
            }
        }

        private string NameTenant() {


            if (lbxScoreBoard.SelectedIndex >= 0)
            {
                string name = "";
                string item = (string)lbxScoreBoard.SelectedItem;

                for (int i = 0; i < item.Length; i++)
                {
                    if (!item[i].Equals(":"))
                    {
                        name += item[i];
                        item = item.Substring(1);
                    }
                    else
                    {
                        break;
                    }
                }

                return name;
            }
            else {
                return null;
            }

            
        }
    }
}
