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

        Bitmap showPassword = Tenant_Application.Properties.Resources.passwordHideWhite;
        Bitmap hidePassword = Tenant_Application.Properties.Resources.passwordShowWhite;

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

        private void BtnLogin_Click(object sender, EventArgs e)
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
                            //Login as landlord
                            if (a.Admin == 1)
                            {
                                LandLordForm landlordInterface = new LandLordForm(a.id, this, a.Name);
                                landlordInterface.Show();
                                this.Hide();

                            }
                            //Login as tenant
                            else
                            {
                                UserInterfaceForm userInterface = new UserInterfaceForm(a.id, a.EmailAddress, a.Password, a.Name, this);
                                userInterface.Show();
                                this.Hide();
                            }
                        }
                        else
                        {
                            Helper.MsgBoxInformation("This account is logged in on a different device!");
                        }
                    }
                    else {
                        Helper.MsgBoxWarning("This account does not exist! OR The Username and Password combination is wrong");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }
        }

 

        private void BtnForgotten_Click(object sender, EventArgs e)
        {
            recovery = new RecoveryForm(this);
            recovery.Show();
            this.Hide();
        }

        private void pbxPassword_Click(object sender, EventArgs e)
        {
            Helper.passwordSwitcher(pbxPassword, tbxPassWord, showPassword, hidePassword);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbxUserName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnLogin_Click(this, new EventArgs());
            }
        }

        private void tbxPassWord_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                BtnLogin_Click(this, new EventArgs());
            }
        }
    }
}
