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

        private DataAccess db; 
        public LoginForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            tbxPassWord.PasswordChar = '*';
            db = new DataAccess();
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
                Helper.MsgBoxWarning("Please, enter your credentials");
            }
            else
            {
                
                try
                {
                    Account a = Helper.ReturnAccountInfo(tbxUserName.Text, tbxPassWord.Text, this.db);
                    if (a != null)
                    {
                        if (a.Online != 1)
                        {

                            if (a.Admin == 1)
                            {
                                LandLordForm landlordInterface = new LandLordForm(a.id, this, a.Name);
                                landlordInterface.Show();
                                this.Hide();

                            }
                            else if (a.Admin == 0)
                            {
                                UserInterfaceForm userInterface = new UserInterfaceForm(a.id, a.EmailAddress, a.Password, a.Name, this);
                                userInterface.Show();
                                this.Hide();
                            }
                            else
                            {
                                Helper.MsgBoxInformation("The Username and Password combination is wrong!");
                            }
                        }
                        else
                        {
                            Helper.MsgBoxInformation("This account is logged in on a different device!");
                        }
                    }
                    else {
                        Helper.MsgBoxWarning("This account does not exist!");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

        //Custom Messageboxes

 

        private void BtnForgotten_Click(object sender, EventArgs e)
        {
            recovery = new RecoveryForm(this);
            recovery.Show();
            this.Hide();
        }
    }
}
