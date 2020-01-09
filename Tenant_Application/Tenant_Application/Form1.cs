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
        RecoveryForm recovery;
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            tbxPassWord.PasswordChar = '*';
        }

        private void LoginForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Closes the whole application and it's thread
            Environment.Exit(-1);
        }

        //Only deletes text on first click on form load
        bool firstTimeUsername = true;
        bool firstTimePassword = true;
        private void TbxUserName_Click(object sender, EventArgs e)
        {
            if(firstTimeUsername)
            {
                firstTimeUsername = false;
                tbxUserName.Clear();
            }
        }

        private void TbxPassWord_Click_1(object sender, EventArgs e)
        {
            if(firstTimePassword)
            {
                firstTimePassword = false;
                tbxPassWord.Clear();
            }
            tbxPassWord.PasswordChar = '*';
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbxUserName.Text) || tbxPassWord.Text.ToLower() == "password" || tbxUserName.Text.ToLower() == "username" || tbxPassWord.Text.ToLower() == "deleted" || tbxUserName.Text.ToLower() == "deleted" || string.IsNullOrWhiteSpace(tbxPassWord.Text))
            {
                MsgBoxWarning("Please, enter your credentials");
            }
            else
            {
                DataAccess db = new DataAccess();

                //Checks for errors
                try
                {
                    List<Account> accounts = db.GetAccountData();
                    bool isIn = false;
                    foreach(Account a in accounts)
                    {
                        if(a.Username == tbxUserName.Text && a.Password == tbxPassWord.Text)
                        {
                            if(a.Admin == 1)
                            {
                                LandLordForm landlordInterface = new LandLordForm(a.id, this, a.Name);
                                isIn = true;
                                landlordInterface.Show();
                                this.Hide();
                                break;
                            }
                            else
                            {
                                UserInterfaceForm userInterface = new UserInterfaceForm(a.id, a.EmailAddress, a.Password, a.Name, this);
                                isIn = true;
                                userInterface.Show();
                                this.Hide();
                                break;
                            }
                        }
                    }
                    if(isIn == false)
                    {
                        MsgBoxWarning("User - name or Password is incorect!");
                        firstTimePassword = true;
                        firstTimeUsername = true;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        //Custom Messageboxes

        public void MsgBoxWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public void MsgBoxInformation(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BtnForgotten_Click(object sender, EventArgs e)
        {
            recovery = new RecoveryForm(this);
            recovery.Show();
            this.Hide();
        }
    }
}
