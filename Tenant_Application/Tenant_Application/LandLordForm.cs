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

            AddScoreBoard();
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

                    MessageBox.Show("Announcement Added");
                    tbxAnnouncement.Clear();
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
            AddScoreBoard();
        }

        private void BtnAddPoint_Click(object sender, EventArgs e)
        {
            string name = NameTenant();

            AlterPoints(name, true);
        }

        private void BtnRmvPoint_Click(object sender, EventArgs e)
        {
            string name = NameTenant();

            AlterPoints(name, false);
        }

        private string NameTenant() {


            if ((string)lbxScoreBoard.SelectedItem != null)
            {
                string name = "";
                string item = (string)lbxScoreBoard.SelectedItem;

                int index = 0;
                while (item[index] != ':')
                {
                    name += item[index].ToString();
                    index++;
                }

                return name;
            }
            else
            {
                return null;
            }

            
        }

        private void AddScoreBoard() {
            lbxScoreBoard.Items.Clear();

            List<Points> pointList = db.GetPoints();
            List<Points> nameList = db.GetNames();

            for (int i = 0; i < pointList.Count; i++)
            {
                lbxScoreBoard.Items.Add(nameList[i].Name + ": " + pointList[i].Point.ToString());
            }
        }

        private void AlterPoints(string name, bool val) {

            if (name != null)
            {
                int id = db.GetIdByName(name)[0].id;

                try
                {
                    if (!String.IsNullOrWhiteSpace(tbxPoint.Text))
                    {
                        switch (val)
                        {
                            case true:
                                db.ChangePoints(Convert.ToInt32(tbxPoint.Text), id);
                                break;
                            default:
                                db.ChangePoints(-Convert.ToInt32(tbxPoint.Text), id);
                                break;
                        }
                        tbxPoint.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Enter the points you want to add or remove!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
            else
            {
                MessageBox.Show("Select a person you want to change");
            }
        }
    }
}
