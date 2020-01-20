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
        //Establish connection with database start
        private static DataType ExecuteQueryWithArgs<DataType>(string query, object arguments)

        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionValue("dbi428024")))
            {
                //get the open connection and ask for the type account data and command issue
                var output = connection.Query<DataType>(query, arguments).FirstOrDefault();
                return output;
            }
        }
        //Establish connection with database end

        private static List<DataType> ExecuteQueryWithArgsInList<DataType>(string query, object arguments)

        {
            using (IDbConnection connection = new SqlConnection(ConnectionHelper.ConnectionValue("dbi428024")))
            {
                //get the open connection and ask for the type account data and command issue
                var output = connection.Query<DataType>(query, arguments).ToList();
                return output;
            }
        }

        //Add announcement
        public void AddAnnouncement(string testing)
        {
            var args = new { Testing = testing };
            var query = "dbo.Annoucements_AddAnnouncement @Testing";

            ExecuteQueryWithArgs<object>(query, args);
        }

        //Get announcements
        public List<Announcement> GetAnnouncements()
        {
            var query = "dbo.Announcement_GetAnnouncement";

            return ExecuteQueryWithArgsInList<Announcement>(query, null);
        }

        //Change points
        public void ChangePoints(int point, int id)
        {
            var args = new { Point = point, Id = id };
            var query = "dbo.Account_ChangePoints @Point, @Id";

            ExecuteQueryWithArgs<object>(query, args);
        }

        //Modify account
        public void ModifyAccount(int id, string username, string password, string email, string name, int admin)
        {
            var args = new { Id= id, Username = username, Password = password, Email = email, Name = name, Admin = admin};
            var query = "dbo.Account_ModifyAccount @Id, @Username, @Password, @Email, @Name, @Admin";

            ExecuteQueryWithArgs<object>(query, args);
        }

        //Delete account
        public void DeleteAccount(int id)
        {
            var args = new { Id = id };
            var query = "dbo.Account_DeleteAccount @Id";

            ExecuteQueryWithArgs<object>(query, args);
        }

        //Use this method for accessing the account info and replace the previous ones
        public List<Account> GetAccountData()
        {
            var query = "dbo.Account_GetAll";

            return ExecuteQueryWithArgsInList<Account>(query, null);
            
        }

        //Add an acoount
        public void AddAccount(string username, string password, string email, string name, int admin)
        {
            var args = new { Username = username, Password = password, EmailAddress = email, Name = name, Admin = admin };
            var query = "dbo.Account_AddAccount @Username, @Password, @EmailAddress, @Name, @Admin";

            ExecuteQueryWithArgs<object>(query, args);
        }

        //Get all the chores for the days
        public List<CalendarDay> GetCalendar()
        {
            var query = "dbo.Calendar_GetAll";
            return ExecuteQueryWithArgsInList<CalendarDay>(query, null);
        }

        //Get the messages sent 
        public List<Chat> GetChat()
        {
            var query = "dbo.Chat_GetAll";
            return ExecuteQueryWithArgsInList<Chat>(query, null);
        }

        //Sends the message
        public void SendChat(string message, int accountId)
        {
            var args = new { Message = message, AccountId = accountId };
            var query = "dbo.Chat_Send @Message, @AccountId";
            ExecuteQueryWithArgs<object>(query, args);
        }

        //0's a chore that has been selected (Points need to be assigned to that person's ID)
        public void UpdateCalendarChores(string day, string chore, string name)
        {
            var args = new { Day = day, Chore = chore, Name = name};
            var query = "dbo.Calendar_UpdateCalendar @Day, @Chore, @Name";

            ExecuteQueryWithArgs<object>(query, args);
        }

        //Set the users on/offline
        public void SetOnline(int id, int online)
        {
            var args = new { Id = id, Online = online };
            var query = "dbo.Account_SetOnline @Id, @Online";

            ExecuteQueryWithArgs<object>(query, args);
        }

        //Manually reset the calendar
        public void ResetCalendar()
        {
            var query = "dbo.Calendar_ResetCalendar";
            ExecuteQueryWithArgs<object>(query, null);
        }
    }
}
