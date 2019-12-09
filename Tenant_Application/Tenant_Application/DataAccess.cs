using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Tenant_Application
{
    public class DataAccess
    {
        public List<Account> GetCredentials(string account)
        {
            //creating a new connection to our sql database
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("TaskBerryDB")))
            {
                //get the open connection and ask for the type account data and command issue
                var output = connection.Query<Account>($"select Username, Password, EmailAddress from Account where Username = '{ account }'").ToList();
                return output;
            }
        }
    }
}
