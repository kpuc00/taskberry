using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenant_Application.Classes.Database
{
    public static class AccessAnnoucement
    {
        public static string AddAnnouncement(string annoucement, int date) 
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("dbi428024")))
            {
                var output = connection.Query<Account>("dbo.Annoucements_AddAnnoucement @Annoucement, @Date", new { Annoucement = annoucement, Date = date }).ToList();
                return output.ToString();
            }
        }
    }
}
