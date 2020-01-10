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
    public partial class RecoveryForm : Form
    {
        DataAccess db = new DataAccess(); //Retrieving info from db
        EmailForward newEmail = new EmailForward(); //Email object
        LoginForm login; //login form object
        public RecoveryForm(LoginForm login)
        {
            InitializeComponent();
            this.login = login;
        }

        private void BtnSend_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbxEmail.Text) || !tbxEmail.Text.EndsWith("@gmail.com"))
            {
                MessageBox.Show("Enter your gmail address to proceed");
            }
            else
            {
                List<Account> accounts = db.GetAccountData(); //all accounts in db
                bool sent = false; //Accessing IF, if it doesn't find the email
                foreach(Account a in accounts)
                {
                    if(a.EmailAddress == tbxEmail.Text)
                    {
                        string data = $"We've received a forgotten password alert from our application TaskBerry. In case that wasn't you - ignore this email. Otherwise, here are your credentials: {Environment.NewLine}Username: {a.Username}{Environment.NewLine}Password: {a.Password}";


                        Helper.MsgBoxInformation(newEmail.SendRecovery(tbxEmail.Text, data, "Password Recovery", "Recovey email sent! Check your email for more information."));

                        //Hides and defaults all values in this form
                        sent = true;
                        tbxEmail.Text = "";
                        this.Hide();
                        login = new LoginForm();
                        login.Show();
                        break;
                    }
                }
                if(sent == false)
                {
                    Helper.MsgBoxWarning("There isn't a user in our database with this email.");
                }
            }
        }

        private void RecoveryForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hides it instead of closing it - will crash otherwise 
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                login = new LoginForm();
                this.Hide();
                login.Show();
            }
        }
    }
}
