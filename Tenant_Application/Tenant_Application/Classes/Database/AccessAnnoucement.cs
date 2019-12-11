using Dapper;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenant_Application.Classes.Database
{
    public class AccessAnnoucement
    {
        public string Annoucement { get; set; }
        public string Date { get; set; }


        public string AddAnnouncement(string annoucement, string date) 
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.ConnectionValue("dbi428024")))
            {
                var output = connection.Query<Account>("dbo.Annoucements_AddAnnoucement @Annoucement, @Date", new { Annoucement = annoucement, Date = date }).ToList();
                return output.ToString();
            }
        }
    }
}
