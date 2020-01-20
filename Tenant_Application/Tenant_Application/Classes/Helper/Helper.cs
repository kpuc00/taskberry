using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenant_Application
{
    public static class Helper
    {
        //Return the data of the specific account trying to log in
        public static Account ReturnAccountInfo(string UserName, string Password, DataAccess db)
        {
            List<Account> accounts = db.GetAccountData(); //Get data from database

            foreach (Account a in accounts) //Iterate through the data
            {
                if (a.Username == UserName && a.Password == Password) //Check if the input data equals retrieved data
                {
                    return a; //Returns the data of the account when a match has occured
                }
            }
            return null; //Returns null if no match found meaning the account does not exist
        }

        //Return the data of the specific account when trying to alter points
        public static Account ReturnAccountInfo(string name, DataAccess db)
        {
            List<Account> accounts = db.GetAccountData(); //Get data from database

            foreach (Account a in accounts) //Iterate through the data
            {
                if (name.Contains(a.Name)) //Check if the input data equals retrieved data
                {
                    return a; //Returns the data of the account when a match has occured
                }
            }
            return null; //Returns null if no match found meaning the account does not exist
        }

        //Handel the logout of an account from landlord form 
        public static bool LogOut(int id, DataAccess db, LandLordForm llf, LoginForm lgf)
        {
            bool val = false;
            //Fancy messagebox with two choices "yes" and "no"
            DialogResult logout = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //If true logout the account
            if (logout == DialogResult.Yes)
            {
                db.SetOnline(id, 0); //Set offline
                lgf.Show();
                //Close the current window
                llf.Hide();
                llf.Dispose();

                val = true;
            }

            return val;
        }

        //Handel the logout of an account from User interface form when close
        public static bool LogOut(int id, DataAccess db, UserInterfaceForm uif, LoginForm lgf)
        {
            bool val = false;
            //Fancy messagebox with two choices "yes" and "no"
            DialogResult logout = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //If true logout the account
            if (logout == DialogResult.Yes)
            {
                db.SetOnline(id, 0); //Set offline
                lgf.Show(); //Show login form
                //Close the current window
                uif.Hide();
                uif.Dispose();



                val = true;
            }
            return val;
        }

        //Get the tenants emails
        public static List<string> AllEmails(DataAccess db)
        {
            List<Account> accounts = db.GetAccountData(); //Get data of the accounts store in list
            List<string> emails = new List<string>(); //List ot store the emails
            foreach (Account a in accounts)
            {
                if (a.Admin != 1) //Check if the account is a tenant
                {
                    emails.Add(a.EmailAddress); //Add the email to the list
                }
            }
            return emails;
        }

        //Handles the showing or hiding of the loggin password
        public static void passwordSwitcher(PictureBox pbx, TextBox tbx, Bitmap showPassword, Bitmap hidePassword)
        {
            if (pbx.Image == showPassword) //If the image is the show icon
            {
                pbx.Image = hidePassword; //Change to the hide icon
                tbx.PasswordChar = char.Parse("\0"); //Show the password
            }
            else
            {
                pbx.Image = showPassword; //Change to the hide icon
                tbx.PasswordChar = '*'; //Hide the password with '*' 
            }
        }

        //Populate the scorebords
        public static string PopulateScoreBoard(Account a)
        {

            string val = "";

            if (a.Admin != 1) //Check if the account is a tenant
            {
                val = $"{a.Name} - {a.Point}"; //Add the name and the coresponding points
                return val;
            }

            return null;
        }

        //Custom messageboxes
        public static void MsgBoxWarning(string message)
        {
            MessageBox.Show(message, "Warning", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static void MsgBoxInformation(string message)
        {
            MessageBox.Show(message, "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //End custom messageboxes
    }
}
