using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        public static Account ReturnAccountInfo(string UserName, string Password, DataAccess db) {
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
    }
}
