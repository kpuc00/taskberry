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



        //Why not just have all account information stored inside the account class instead of calling every 
        //Time for different data and temporary storing it
        //What is more resource heavy: Holding 6 objects in a class OR calling for different fields of an object
        //everytime you need the information






        //Can be stored inside an account object
        public Account GetAccountByUsername(string username)
        {
            //creating a new connection to our sql database
            var args = new { Text = username };
            var query = "dbo.Account_GetAccountByUsername @Text";

            return ExecuteQueryWithArgs<Account>(query, args);
        }

        //Can be stored inside an account object

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
        //Can be stored inside an account object
        public int GetIdByName(string name)
        {
            var args = new { Name = name };
            var query = "dbo.Account_GetIdByName @Name";

            return ExecuteQueryWithArgs<int>(query, args );
        }
        //Can be stored inside an account object
        public string GetEmailById(int id)
        {
            var args = new { Id = id };
            var query = "dbo.Account_GetEmailById @Id";

            return ExecuteQueryWithArgs<string>(query, args);
        }
        //Can be stored inside an account object
        public string GetPasswordById(int id)
        {
            var args = new { Id = id };
            var query = "dbo.Account_GetPasswordById @Id";

            return ExecuteQueryWithArgs<string>(query, args);
        }

        //Can be stored inside an account object
        public string GetNameById(int id)
        {
            var args = new { Id = id };
            var query = "dbo.Account_GetNameById @Id";

            return ExecuteQueryWithArgs<string>(query, args);
        }
        //Can be stored inside an account object
        public Account GetAccountById(int id)
        {
            var args = new { Id = id };
            var query = "dbo.Account_GetAccountById @Id";

            return ExecuteQueryWithArgs<Account>(query, args);
        }
        //Can be stored inside an account object
        public Chore GetChoreByName(string chore)
        {
            var args = new { Text = chore };
            var query = "dbo.Chores_GetByName @Text";

            return ExecuteQueryWithArgs<Chore>(query, args);
        }

        //Adds an announcement to the database, takes date of pc and the actual announcement as parameters
        public void AddAnnouncement(string date, string testing)
        {
            var args = new { Date = date, Testing = testing };
            var query = "dbo.Annoucements_AddAnnouncement @Date, @Testing";

            ExecuteQueryWithArgs<object>(query, args);
        }

        //Gets all of the announcements and date in the database and stores em in objects
        public List<Announcement> GetAnnouncements()
        {
            var query = "dbo.Announcement_GetAnnouncement";

            return ExecuteQueryWithArgsInList<Announcement>(query, null);
        }

        //An unsuccessful atempt of mine using your idea. Should be deleted.
        public List<Chore> GetEmptyChores(int chore, int day)
        {

            var args = new { Chore = chore, Day =  day};
            var query = "dbo.GetEmptyChores @Chore, @Day";
            return ExecuteQueryWithArgsInList<Chore>(query, args);
        }
        //Why?
        public List<Announcement> GetAnnouncementsDates()
        {
            var query = "dbo.Announcement_GetDate";
            return ExecuteQueryWithArgsInList<Announcement>(query, null);
        }
        //Takes the points inside of a tbx and sets them for the selected person 
        public void ChangePoints(int point, int id)
        {
            var args = new { Point = point, Id = id };
            var query = "dbo.Account_ChangePoints @Point, @Id";

            ExecuteQueryWithArgs<object>(query, args);
        }

        //Gets all account information and stores in an object || Should be replaced by a method to receieve all Account information
        public List<Account> GetPoints()
        {
            var query = "dbo.Account_GetPoints";

            return ExecuteQueryWithArgsInList<Account>(query, null);
            
            
            //throw new Exception("FUCK ME IN THE ASS, IT SHOULD NOT BE HERE MICHAEL(B, NOT GROENEWEGEN VAN DER WEIJDEN) WAKE THE FUCK UP, YOU TWAT");
        }

        //Why?
        public int GetPointsById(int id)
        {
            var args = new { Id = id };
            var query = "dbo.Account_GetPoints @Id";

            return ExecuteQueryWithArgs<int>(query, args);
        }

        //Creates objects for the days of the week each filled with the Chores || Wherever the value is 0, the chore is taken
        public List<CalendarDays> Calendar()
        {
            var query = "dbo.GetCalendar";
            return ExecuteQueryWithArgsInList<CalendarDays>(query, null);
        }

        //0's a chore that has been selected (Points need to be assigned to that person's ID)
        public void SetCalendar(string day, string chore)
        {
            var args = new { Dayum = day, Chore = chore};
            var query = "dbo.ModifyCalendar @Dayum, @Chore";

            ExecuteQueryWithArgs<object>(query, args);
        }

        //Why?
        public string GetAccountByName()
        {
            throw new Exception("MICHAEL(B, NOT GROENEWEGEN VAN DER WEIJDEN) YOU STUPID IDIOT, IT'S THE SECOND TIME YOU FUCK UP");

        }
    }
}
