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
        UserInterfaceForm uif = new UserInterfaceForm();
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
                UserInterfaceForm newForm = new UserInterfaceForm();
                newForm.MsgBoxWarning("Please, enter your credentials");
            }
            else
            {
<<<<<<< Updated upstream
                this.Hide();
                uif.Show();
=======
                
                DataAccess db = new DataAccess();

                //Checks for errors
                try
                {

                    if (db.GetIdByCredentials(tbxUserName.Text, tbxPassWord.Text) > 0)
                    {
                        int id = db.GetIdByCredentials(tbxUserName.Text, tbxPassWord.Text);

                        switch (id)
                        {
                            //Log in LandLord
                            case 1:
                                LandLordForm landLordInterface = new LandLordForm(id);

                                landLordInterface.Show();
                                break;
                            //Log in Tenant
                            default:

                                string email = db.GetEmailById(id);
                                string username = tbxUserName.Text;
                                string password = db.GetPasswordById(id);

                                UserInterfaceForm userInterface = new UserInterfaceForm(id, email, username, password);


                                userInterface.Show();
                                break;
                        }

                        //Hides the login screen
                        this.Hide();

                    }
                    else
                    {
                        MsgBoxWarning("User - name or Password is incorect!");
                        firstTimePassword = true;
                        firstTimeUsername = true;
                    }
                } catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
>>>>>>> Stashed changes
            }
        }

        private void LoginForm_Load(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.FixedDialog;

        }
    }
}
