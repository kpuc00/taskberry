﻿using System;
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


        public int GetIdByCredentials(string user, string pass)
        {
            var args = new { User = user, Pass = pass };
            var query = "dbo.Account_GetIdByCredentials @Pass, @User";

            return ExecuteQueryWithArgs<int>(query, args);
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

        public string GetNameById(int id)
        {
            var args = new { Id = id };
            var query = "dbo.Account_GetNameById @Id";

            return ExecuteQueryWithArgs<string>(query, args);
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

        public void ChangePoints(int point, int id)
        {
            var args = new { Point = point, Id = id };
            var query = "dbo.Account_ChangePoints @Point, @Id";

            ExecuteQueryWithArgs<object>(query, args);
        }
        //Use this method for accessing the account info and replace the previous ones
        public List<Account> GetAccountData()
        {
            var query = "dbo.Account_GetAll";

            return ExecuteQueryWithArgsInList<Account>(query, null);
            
        }

        public List<CalendarDays> GetCalendar()
        {
            var query = "dbo.Calendar_GetAll";
            return ExecuteQueryWithArgsInList<CalendarDays>(query, null);
        }

        //0's a chore that has been selected (Points need to be assigned to that person's ID)
        public void UpdateCalendarChores(string day, string chore)
        {
            var args = new { Day = day, Chore = chore};
            var query = "dbo.Calendar_UpdateCalendar @Day, @Chore";

            ExecuteQueryWithArgs<object>(query, args);
        }
    }
}
