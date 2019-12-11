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
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("dbi428024")))
            {
                //get the open connection and ask for the type account data and command issue
                var output = connection.Query<Account>("dbo.Account_GetAccountByUsername @Text", new { Text = username }).ToList();
                return output;
            }
        }

        public List<Account> GetPassword(string password)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("dbi428024")))
            {
                var output = connection.Query<Account>("dbo.Account_GetAccountByPassword @Text", new { Text = password }).ToList();
                return output;
            }
        }
        public List<Account> GetIdByCredentials(string user, string pass)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("dbi428024")))
            {
                var output = connection.Query<Account>("dbo.Account_GetIdByCredentials @Pass, @User", new { User = user, Pass = pass }).ToList();
                return output;
            }
        }
        public List<Account> GetEmailById(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("dbi428024")))
            {
                var output = connection.Query<Account>("dbo.Account_GetEmailById @Id", new { Id = id }).ToList();
                return output;
            }
        }
        public List<Account> GetPasswordById(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("dbi428024")))
            {
                var output = connection.Query<Account>("dbo.Account_GetPasswordById @Id", new { Id = id }).ToList();
                return output;
            }
        }

        public List<Account> GetName(string name)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("dbi428024")))
            {
                var output = connection.Query<Account>("dbo.Account_GetAccountByName @Text", new { Text = name }).ToList();
                return output;
            }
        }
        public List<Account> GetId(int id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("dbi428024")))
            {
                var output = connection.Query<Account>("dbo.Account_GetAccountById @Id", new { Id = id }).ToList();
                return output;
            }
        }
        public List<Chore> GetChore(string chore)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("dbi428024")))
            {
                var output = connection.Query<Chore>("dbo.Chores_GetByName @Text", new { Text = chore }).ToList();
                return output;
            }   
        }

        public List<Announcement> AddAnnouncement(string annoucement, string date)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("dbi428024")))
            {
                var output = connection.Query<Announcement>("dbo.Annoucements_AddAnnoucement @Annoucement, @Date", new { Annoucement = annoucement, Date = date }).ToList();
                return output;
            }
        }
        public List<Announcement> GetAnnouncement()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("dbi428024")))
            {
                var output = connection.Query<Announcement>("dbo.Annoucements_GetAnnouncement @Announcement, @Date").ToList();
                return output;
            }
        }
    }
}
