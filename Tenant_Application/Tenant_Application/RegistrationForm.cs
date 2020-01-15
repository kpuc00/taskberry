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
    public partial class RegistrationForm : Form
    {
        DataAccess db = new DataAccess();
        LandLordForm llf; //Existing instance of the landlordform

        Bitmap showPassword = Tenant_Application.Properties.Resources.passwordHideWhite;
        Bitmap hidePassword = Tenant_Application.Properties.Resources.passwordShowWhite;
        public RegistrationForm(LandLordForm llf)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.llf = llf;
            tbxRegPassword.PasswordChar = '*';
        }
        
        //If either textbox is either empty or in RED (not meeting criteria), it won't update the database with the new information
        private void BtnCreateAcc_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(tbxRegEmail.Text) || string.IsNullOrWhiteSpace(tbxRegName.Text) ||
                    string.IsNullOrWhiteSpace(tbxRegPassword.Text) || string.IsNullOrWhiteSpace(tbxRegUsername.Text) ||
                    tbxRegUsername.BackColor == Color.IndianRed || tbxRegPassword.BackColor == Color.IndianRed ||
                    tbxRegEmail.BackColor == Color.IndianRed || tbxRegName.BackColor == Color.IndianRed)
                {
                    Helper.MsgBoxWarning("Incorrect information!");
                }
                else
                {
                    int isAdmin = 0;
                    if(cbxAdmin.Checked)
                    {
                        isAdmin = 1;
                    }
                    db.AddAccount(tbxRegUsername.Text, tbxRegPassword.Text, tbxRegEmail.Text, tbxRegName.Text, isAdmin);
                    Helper.MsgBoxInformation("You created a new account");
                    llf.UpdateAccounts();
                    llf.UpdateLbxScore();
                }
            }
            catch(Exception ex)
            {
                Helper.MsgBoxWarning(ex.ToString());
            }
        }

        /*This part is only for checking the actual accounts if they already contain this username,
        * password, email or name.
        * 
        * It could've been done with 1 event BUT that would be a 150+ line nested loop which would 
        * be a pain in the ass to troubleshoot in case something went wrong.
        * 
        * Also - the events check for different things contained inside of the textbox so it
        * wouldn't be a good idea to make it all inside of 1 event
        */

        private void TbxRegUsername_TextChanged(object sender, EventArgs e)
        {
            List<Account> accounts = db.GetAccountData(); //GEt the account info
            string temp = ""; //Stores the taken Username from the textbox, so when it searches the other account objects - it doesn't get skipped
            if (!string.IsNullOrWhiteSpace(tbxRegUsername.Text) && tbxRegUsername.Text.Length >= 4 && tbxRegUsername.Text.Length <= 25)
            {
                //Loops through the existing accounts to see if the username already exists
                for (int i = 0; i < accounts.Count; i++)
                {

                    if (accounts[i].Username.ToLower() == tbxRegUsername.Text.ToLower()) //If it does
                    {
                        tbxRegUsername.BackColor = Color.IndianRed; //Textbx colour red
                        //Show label with information
                        lblStatusUsername.Visible = true; 
                        lblStatusUsername.Text = "Username is taken"; 
                        temp = tbxRegUsername.Text.ToLower();
                    }
                    else if (temp != tbxRegUsername.Text.ToLower()) //Makes sure that the program doesn't skip an already checked account
                    {
                        tbxRegUsername.BackColor = Color.LightGreen;
                        lblStatusUsername.Text = "Username is taken";
                        lblStatusUsername.Visible = false;
                    }
                }
            }
            else
            {
                lblStatusUsername.Visible = true;
                lblStatusUsername.Text = "Between 4-25 characters"; 
                tbxRegUsername.BackColor = Color.IndianRed;
            }
        }

        private void TbxRegPassword_TextChanged(object sender, EventArgs e)
        {
            List<Account> accounts = db.GetAccountData();

            //Checks if password taken
            if (!string.IsNullOrWhiteSpace(tbxRegPassword.Text) && tbxRegPassword.Text.Length >= 4 && tbxRegPassword.Text.Length <= 25)
            {
                tbxRegPassword.BackColor = Color.LightGreen;
                lblStatusPassword.Text = "Password is taken";
                lblStatusPassword.Visible = false;
            }
            else
            {
                lblStatusPassword.Visible = true;
                lblStatusPassword.Text = "Between 4-25 characters";
                tbxRegPassword.BackColor = Color.IndianRed;
            }
        }

        private void TbxRegEmail_TextChanged(object sender, EventArgs e)
        {
            List<Account> accounts = db.GetAccountData();
            string temp = ""; //Stores the taken Email from the textbox, so when it searches the other account objects - it doesn't get skipped
            //Checks to add new email
            if (!string.IsNullOrWhiteSpace(tbxRegEmail.Text) && tbxRegEmail.Text.Length >= 8) //Text must exist
            {
                if (tbxRegEmail.Text.EndsWith("@gmail.com")) //Must end with "@gmail.com"
                {
                    //Loops through existing accounts
                    for (int i = 0; i < accounts.Count; i++)
                    {
                        //Checks if email taken
                        if (accounts[i].EmailAddress.ToLower() == tbxRegEmail.Text.ToLower()) 
                        {
                            tbxRegEmail.BackColor = Color.IndianRed;
                            lblStatusEmail.Visible = true;
                            lblStatusEmail.Text = "Email is taken";
                            temp = tbxRegEmail.Text.ToLower();
                        }
                        else if (temp != tbxRegEmail.Text.ToLower())
                        {
                            tbxRegEmail.BackColor = Color.LightGreen;
                            lblStatusEmail.Text = "Email is taken";
                            lblStatusEmail.Visible = false;
                        }
                    }
                }
                else
                {
                    lblStatusEmail.Visible = true;
                    lblStatusEmail.Text = "Only gmail accounts";
                    tbxRegEmail.BackColor = Color.IndianRed;
                }
            }
            else
            {
                lblStatusEmail.Visible = true;
                lblStatusEmail.Text = "At least 8 characters";
                tbxRegEmail.BackColor = Color.IndianRed;
            }
        }

        private void TbxRegName_TextChanged(object sender, EventArgs e)
        {
            List<Account> accounts = db.GetAccountData();
            string temp = ""; //Stores the taken Name from the textbox, so when it searches the other account objects - it doesn't get skipped
            if (!string.IsNullOrWhiteSpace(tbxRegName.Text) && tbxRegName.Text.Length >= 4 && tbxRegName.Text.Length <= 25)
            {
                if(!tbxRegName.Text.StartsWith("0") && !tbxRegName.Text.StartsWith("1") && !tbxRegName.Text.StartsWith("2") &&
                    !tbxRegName.Text.StartsWith("3") && !tbxRegName.Text.StartsWith("4") && !tbxRegName.Text.StartsWith("5") &&
                    !tbxRegName.Text.StartsWith("6") && !tbxRegName.Text.StartsWith("7") && !tbxRegName.Text.StartsWith("8") &&
                    !tbxRegName.Text.StartsWith("9")) {
                    //Loops through existing acounts
                    for (int i = 0; i < accounts.Count; i++)
                    {
                        //Checks if name is taken
                        if (accounts[i].Name.ToLower() == tbxRegName.Text.ToLower())
                        {
                            tbxRegName.BackColor = Color.IndianRed;
                            lblStatusName.Visible = true;
                            lblStatusName.Text = "Name is taken";
                            temp = tbxRegName.Text.ToLower();
                        }
                        else if (temp != tbxRegName.Text.ToLower())
                        {
                            tbxRegName.BackColor = Color.LightGreen;
                            lblStatusName.Text = "Name is taken";
                            lblStatusName.Visible = false;
                        }
                    }

                }
                else
                {
                    lblStatusName.Visible = true;
                    lblStatusName.Text = "Can't start with a digit";
                    tbxRegName.BackColor = Color.IndianRed;
                }
            }
            else
            {
                lblStatusName.Visible = true;
                lblStatusName.Text = "Between 4-25 characters";
                tbxRegName.BackColor = Color.IndianRed;
            }
        }

        //Only hides the instance, otherwise program will crash
        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
        
        private void pbxPassword_Click(object sender, EventArgs e)
        {
            Helper.passwordSwitcher(pbxPassword, tbxRegPassword, showPassword, hidePassword);
        }
    }
}
