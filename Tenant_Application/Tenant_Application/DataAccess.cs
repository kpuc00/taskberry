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
        public List<Account> GetUsername(string username)
        {
            //creating a new connection to our sql database
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("dbi428024")))
            {
                //get the open connection and ask for the type account data and command issue
                var output = connection.Query<Account>("dbo.Account_GetByUsername @Text", new { Text = username }).ToList();
                return output;
            }
        }
        public List<Account> GetPassword(string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("dbi428024")))
            {
                var output = connection.Query<Account>("dbo.Account_GetByPassword @Text", new { Text = password }).ToList();
                return output;
            }
        }
        public List<Account> GetName(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("dbi428024")))
            {
                var output = connection.Query<Account>("dbo.Account_GetByName @Text", new { Text = name }).ToList();
                return output;
            }
        }
        public List<Account> GetId(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("dbi428024")))
            {
                var output = connection.Query<Account>("dbo.Account_GetById @Id", new { Id = id }).ToList();
                return output;
            }
        }
        public List<Chore> GetChore(string chore)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("dbi428024")))
            {
                var output = connection.Query<Chore>("dbo.Account_GetByUsername @Text", new { Text = chore }).ToList();
                return output;
            }
        }
    }
}
