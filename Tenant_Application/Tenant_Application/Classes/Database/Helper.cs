using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tenant_Application
{
    public static class Helper
    {
        //creating a helper with the connectin string
        public static string ConnectionValue(string name)
        {
            //accessing the connection string from the config manager
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }

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
        public static void LogOut(int id, DataAccess db, LandLordForm llf, LoginForm lgf)
        {
            //Fancy messagebox with two choices "yes" and "no"
            DialogResult logout = MessageBox.Show("Are u sure u want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //If true logout the account
            if (logout == DialogResult.Yes)
            {
                db.SetOnline(id, 0);
                lgf.Show();
                llf.Hide();
                llf.Dispose();
            }

        }

        //Handel the logout of an account from landlord form when close
        public static bool LogOut(int id, DataAccess db, LandLordForm llf)
        {
            bool val = false;
            //Fancy messagebox with two choices "yes" and "no"
            DialogResult logout = MessageBox.Show("Are u sure u want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //If true logout the account
            if (logout == DialogResult.Yes)
            {
                db.SetOnline(id, 0);
                llf.Hide();
                llf.Dispose();

                val = true;
            }

            return val;
        }

        //Handel the logout of an account from User interface form
        public static void LogOut(int id, DataAccess db, UserInterfaceForm uif, LoginForm lgf)
        { 
            //Fancy messagebox with two choices "yes" and "no"
            DialogResult logout = MessageBox.Show("Are u sure u want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //If true logout the account
            if (logout == DialogResult.Yes)
            {
                db.SetOnline(id, 0);
                lgf.Show();
                uif.Hide();
                uif.Dispose();
            }
        }

        //Handel the logout of an account from User interface form when close
        public static bool LogOut(int id, DataAccess db, UserInterfaceForm uif)
        {
            bool val = false;
            //Fancy messagebox with two choices "yes" and "no"
            DialogResult logout = MessageBox.Show("Are u sure u want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            //If true logout the account
            if (logout == DialogResult.Yes)
            {
                db.SetOnline(id, 0);
                uif.Hide();
                uif.Dispose();

                val = true;
            }

            return val;
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
    }
}