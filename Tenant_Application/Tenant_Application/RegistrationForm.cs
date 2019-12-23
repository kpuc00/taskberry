﻿using System;
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
        public RegistrationForm()
        {
            InitializeComponent();
            this.FormBorderStyle = FormBorderStyle.FixedDialog;
        }

        private void BtnCreateAcc_Click(object sender, EventArgs e)
        {
            try
            {


                if (string.IsNullOrWhiteSpace(tbxRegEmail.Text) || string.IsNullOrWhiteSpace(tbxRegName.Text) ||
                    string.IsNullOrWhiteSpace(tbxRegPassword.Text) || string.IsNullOrWhiteSpace(tbxRegUsername.Text) ||
                    tbxRegUsername.BackColor == Color.IndianRed || tbxRegPassword.BackColor == Color.IndianRed ||
                    tbxRegEmail.BackColor == Color.IndianRed || tbxRegName.BackColor == Color.IndianRed)
                {
                    MsgBoxWarning("Incorrect information!");
                }
                else
                {
                    db.AddAccount(tbxRegUsername.Text, tbxRegPassword.Text, tbxRegEmail.Text, tbxRegName.Text);
                    MsgBoxInformation("You created a new account");
                }
            }
            catch(Exception ex)
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

        private void TbxRegUsername_TextChanged(object sender, EventArgs e)
        {
            List<Account> accounts = db.GetAccountData();
            string temp = ""; //Stores the taken Username from the textbox, so when it searches the other account objects - it doesn't get skipped
            if (!string.IsNullOrWhiteSpace(tbxRegUsername.Text) && tbxRegUsername.Text.Length >= 4)
            {
                for (int i = 0; i < accounts.Count; i++)
                {

                    if (accounts[i].Username.ToLower() == tbxRegUsername.Text.ToLower())
                    {
                        tbxRegUsername.BackColor = Color.IndianRed;
                        lblStatusUsername.Visible = true;
                        lblStatusUsername.Text = "Username is taken";
                        temp = tbxRegUsername.Text.ToLower();
                    }
                    else if (temp != tbxRegUsername.Text.ToLower())
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
                lblStatusUsername.Text = "At least 4 characters";
                tbxRegUsername.BackColor = Color.IndianRed;
            }
        }

        private void TbxRegPassword_TextChanged(object sender, EventArgs e)
        {
            List<Account> accounts = db.GetAccountData();
            string temp = ""; //Stores the taken Password from the textbox, so when it searches the other account objects - it doesn't get skipped
            if (!string.IsNullOrWhiteSpace(tbxRegPassword.Text) && tbxRegPassword.Text.Length >= 4)
            {
                for (int i = 0; i < accounts.Count; i++)
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
            else
            {
                lblStatusPassword.Visible = true;
                lblStatusPassword.Text = "At least 4 characters";
                tbxRegPassword.BackColor = Color.IndianRed;
            }
        }

        private void TbxRegEmail_TextChanged(object sender, EventArgs e)
        {
            List<Account> accounts = db.GetAccountData();
            string temp = ""; //Stores the taken Email from the textbox, so when it searches the other account objects - it doesn't get skipped
            if (!string.IsNullOrWhiteSpace(tbxRegEmail.Text) && tbxRegEmail.Text.Length >= 8)
            {
                if (tbxRegEmail.Text.EndsWith("@gmail.com"))
                {
                    for (int i = 0; i < accounts.Count; i++)
                    {

                        if (accounts[i].EmailAddress.ToLower() == tbxRegEmail.Text.ToLower())
                        {
                            tbxRegEmail.BackColor = Color.IndianRed;
                            lblStatusEmail.Visible = true;
                            lblStatusEmail.Text = "Email is taken";
                            temp = lblStatusEmail.Text.ToLower();
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
            if (!string.IsNullOrWhiteSpace(tbxRegName.Text) && tbxRegName.Text.Length >= 4)
            {
                for (int i = 0; i < accounts.Count; i++)
                {

                    if (accounts[i].Name.ToLower() == tbxRegName.Text.ToLower())
                    {
                        tbxRegName.BackColor = Color.IndianRed;
                        lblStatusName.Visible = true;
                        lblStatusName.Text = "Name is taken";
                        temp = lblStatusName.Text.ToLower();
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
                lblStatusName.Text = "At least 4 characters";
                tbxRegName.BackColor = Color.IndianRed;
            }
        }

        private void RegistrationForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(e.CloseReason == CloseReason.UserClosing)
            {
                e.Cancel = true;
                this.Hide();
            }
        }
    }
}
