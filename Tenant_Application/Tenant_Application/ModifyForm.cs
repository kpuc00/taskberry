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
    public partial class ModifyForm : Form
    {
        DataAccess db = new DataAccess();
        //Local fields of the SELECTED ACCOUNT
        int id;
        string username;
        string password;
        string email;
        string name;
        int admin;
        LandLordForm llf;

        public ModifyForm(Account account, LandLordForm llf)
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
            this.llf = llf;
            this.id = account.id;
            this.username = account.Username;
            this.password = account.Password;
            this.email = account.EmailAddress;
            this.name = account.Name;
            this.admin = account.Admin;
            lblRegMain.Text = $"Modify {name}'s account";
            //Fills the textboxes with the current information of the account
            tbxRegUsername.Text = this.username;
            tbxRegPassword.Text = this.password;
            tbxRegEmail.Text = this.email;
            tbxRegName.Text = this.name;
        }

        private void BtnCreateAcc_Click(object sender, EventArgs e)
        {
            try
            {
                //If the textboxes are blank or red in color
                if (string.IsNullOrWhiteSpace(tbxRegEmail.Text) || string.IsNullOrWhiteSpace(tbxRegName.Text) ||
                    string.IsNullOrWhiteSpace(tbxRegPassword.Text) || string.IsNullOrWhiteSpace(tbxRegUsername.Text) ||
                    tbxRegUsername.BackColor == Color.IndianRed || tbxRegPassword.BackColor == Color.IndianRed ||
                    tbxRegEmail.BackColor == Color.IndianRed || tbxRegName.BackColor == Color.IndianRed)
                {
                    MsgBoxWarning("Incorrect information!");
                }
                else //Sends the information to the database and changes account information
                {
                    int isAdmin = 0;
                    if (cbxAdmin.Checked)
                    {
                        isAdmin = 1;
                    }
                    if (isAdmin == 0 && this.admin == 1)
                    {
                        MsgBoxInformation("You can't revoke your own landlord status");
                    }
                    else
                    {
                        db.ModifyAccount(this.id, tbxRegUsername.Text, tbxRegPassword.Text, tbxRegEmail.Text, tbxRegName.Text, isAdmin);
                        MsgBoxInformation("You modified an account!");
                        llf.UpdateAccounts();
                        llf.UpdateLbxScore();
                    }
                }
            }
            catch (Exception ex)
            {
                MsgBoxWarning(ex.ToString());
            }
        }

        public void MsgBoxWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }
        public void MsgBoxInformation(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
            List<Account> accounts = db.GetAccountData(); //All account objects
            string temp = ""; //Stores the taken Username from the textbox, so when it searches the other account objects - it doesn't get skipped
            if (!string.IsNullOrWhiteSpace(tbxRegUsername.Text) && tbxRegUsername.Text.Length >= 4 && tbxRegUsername.Text.Length <= 25)
            {
                for (int i = 0; i < accounts.Count; i++)
                {
                    if (accounts[i].Username.ToLower() != this.username.ToLower()) //Excludes the account you're modiffying currently
                    {
                        if (accounts[i].Username.ToLower() == tbxRegUsername.Text.ToLower()) //If the acc username and textbox are the same
                        {
                            tbxRegUsername.BackColor = Color.IndianRed;
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
            string temp = ""; //Stores the taken Password from the textbox, so when it searches the other account objects - it doesn't get skipped
            if (!string.IsNullOrWhiteSpace(tbxRegPassword.Text) && tbxRegPassword.Text.Length >= 4 && tbxRegPassword.Text.Length <= 25)
            {
                for (int i = 0; i < accounts.Count; i++)
                {
                    if (accounts[i].Password.ToLower() != this.password.ToLower())
                    {
                        if (accounts[i].Password.ToLower() == tbxRegPassword.Text.ToLower())
                        {
                            tbxRegPassword.BackColor = Color.IndianRed;
                            lblStatusPassword.Visible = true;
                            lblStatusPassword.Text = "Password is taken";
                            temp = tbxRegPassword.Text.ToLower();
                        }
                        else if (temp != tbxRegPassword.Text.ToLower())
                        {
                            tbxRegPassword.BackColor = Color.LightGreen;
                            lblStatusPassword.Text = "Password is taken";
                            lblStatusPassword.Visible = false;
                        }
                    }
                }
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
            if (!string.IsNullOrWhiteSpace(tbxRegEmail.Text) && tbxRegEmail.Text.Length >= 8)
            {
                if (tbxRegEmail.Text.EndsWith("@gmail.com")) //Only gmail accounts are accepted because of smtp server
                {
                    for (int i = 0; i < accounts.Count; i++)
                    {
                        if (accounts[i].EmailAddress != this.email.ToLower())
                        {
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
                for (int i = 0; i < accounts.Count; i++)
                {
                    if (accounts[i].Name.ToLower() != this.name.ToLower())
                    {
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
            }
            else
            {
                lblStatusName.Visible = true;
                lblStatusName.Text = "Between 4-25 characters";
                tbxRegName.BackColor = Color.IndianRed;
            }
        }

        private void ModifyForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Hides it instead of closing it - will crash otherwise 
            if (e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
