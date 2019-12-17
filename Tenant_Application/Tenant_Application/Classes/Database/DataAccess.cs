using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace Tenant_Application
{
    public class DataAccess
    {
        private static DataType ExecuteQueryWithArgs<DataType>(string query, object arguments)

        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("dbi428024")))
            {
                //get the open connection and ask for the type account data and command issue
                var output = connection.Query<DataType>(query, arguments).FirstOrDefault();
                return output;
            }
        }
        private static List<DataType> ExecuteQueryWithArgsInList<DataType>(string query, object arguments)

        {
            using (IDbConnection connection = new SqlConnection(Helper.ConnectionValue("dbi428024")))
            {
                //get the open connection and ask for the type account data and command issue
                var output = connection.Query<DataType>(query, arguments).ToList();
                return output;
            }
        }
        public Account GetAccountByUsername(string username)
        {
            //creating a new connection to our sql database
            var args = new { Text = username };
            var query = "dbo.Account_GetAccountByUsername @Text";

            return ExecuteQueryWithArgs<Account>(query, args);
        }
        //public List<Account> GetAccountByPassword(string password)
        //{
        //    return ExecuteQueryWithArgs<Account>("dbo.Account_GetAccountByPassword @Text", password);
        //}
        public int GetIdByCredentials(string user, string pass)
        {
            var args = new { User = user, Pass = pass };
            var query = "dbo.Account_GetIdByCredentials @Pass, @User";

            return ExecuteQueryWithArgs<int>(query, args);
        }
        public int GetIdByName(string name)
        {
            var args = new { Name = name };
            var query = "dbo.Account_GetIdByName @Name";

            return ExecuteQueryWithArgs<int>(query, args );
        }
        public string GetEmailById(int id)
        {
            var args = new { Id = id };
            var query = "dbo.Account_GetEmailById @Id";

            return ExecuteQueryWithArgs<string>(query, args);
        }
        public string GetPasswordById(int id)
        {
            var args = new { Id = id };
            var query = "dbo.Account_GetPasswordById @Id";

            return ExecuteQueryWithArgs<string>(query, args);
        }
        public Account GetAccountById(int id)
        {
            var args = new { Id = id };
            var query = "dbo.Account_GetAccountById @Id";

            return ExecuteQueryWithArgs<Account>(query, args);
        }
        public Chore GetChoreByName(string chore)
        {
            var args = new { Text = chore };
            var query = "dbo.Chores_GetByName @Text";

            return ExecuteQueryWithArgs<Chore>(query, args);
        }
        public void AddAnnouncement(string date, string testing)
        {
            var args = new { Date = date, Testing = testing };
            var query = "dbo.Annoucements_AddAnnouncement @Date, @Testing";

            ExecuteQueryWithArgs<object>(query, args);
        }
        public List<Announcement> GetAnnouncements()
        {
            var query = "dbo.Announcement_GetAnnouncement";

            return ExecuteQueryWithArgsInList<Announcement>(query, null);
        }

        //This is useless
        
        //public List<Announcement> GetAnnouncementsDates()
        //{
        //    var query = "dbo.Announcement_GetDate";
        //    return ExecuteQueryWithArgsInList<Announcement>(query, null);
        //}
        
        public void ChangePoints(int point, int id)
        {
            var args = new { Point = point, Id = id };
            var query = "dbo.Account_ChangePoints @Point, @Id";

            ExecuteQueryWithArgs<object>(query, args);
        }
        public List<Account> GetPoints()
        {
            var query = "dbo.Account_GetPoints";

            return ExecuteQueryWithArgsInList<Account>(query, null);
            
            
            //throw new Exception("FUCK ME IN THE ASS, IT SHOULD NOT BE HERE MICHAEL(B, NOT GROENEWEGEN VAN DER WEIJDEN) WAKE THE FUCK UP, YOU TWAT");
        }
        //public int GetPointsById(int id)
        //{
        //    var args = new { Id = id };
        //    var query = "dbo.Account_GetPoints @Id";

        //    return ExecuteQueryWithArgs<int>(query, args);
        //}
        public string GetAccountByName()
        {
            throw new Exception("MICHAEL(B, NOT GROENEWEGEN VAN DER WEIJDEN) YOU STUPID IDIOT, IT'S THE SECOND TIME YOU FUCK UP");

        }
    }
}
