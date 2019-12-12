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
            string announcement;
            if (!String.IsNullOrWhiteSpace(tbxAnnouncement.Text))
            {
                announcement = tbxAnnouncement.Text;
                try
                {
                    db.AddAnnouncement(announcement, DateTime.Today.ToString());
                }
                catch (Exception ex) {
                    MessageBox.Show(ex.ToString());
                }
            }
            else {
                MessageBox.Show("Enter an announcement!");
            }
            
            
        }

        private void tabAnnouncement_Click(object sender, EventArgs e)
        {

        }
    }
}
