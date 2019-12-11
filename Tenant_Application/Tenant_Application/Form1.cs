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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void TbxUserName_Click(object sender, EventArgs e)
        {
            tbxUserName.Clear();
        }


        private void TbxPassWord_Click_1(object sender, EventArgs e)
        {
            tbxPassWord.Clear();
            tbxPassWord.PasswordChar = '*';
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbxUserName.Text) || tbxPassWord.Text == "Password" || tbxUserName.Text == "Username" || string.IsNullOrWhiteSpace(tbxPassWord.Text))
            {
                MessageBox.Show("Please, enter your credentials");
            }
            else
            {
                DataAccess db = new DataAccess();
                if (db.GetIdByCredentials(tbxUserName.Text, tbxPassWord.Text).Count > 0)
                {
                    int id = db.GetIdByCredentials(tbxUserName.Text, tbxPassWord.Text)[0].id;
                    string email = db.GetEmailById(id)[0].EmailAddress.ToString();
                    string password = db.GetPasswordById(id)[0].Password.ToString();
                    UserInterfaceForm userInterface = new UserInterfaceForm(id, email, password);
                    this.Hide();
                    userInterface.Show();
                }
                else
                {
                    MessageBox.Show("Nope");
                }
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

        }

        private void PbxLogo_Click(object sender, EventArgs e)
        {

        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(-1);
        }
    }
}
