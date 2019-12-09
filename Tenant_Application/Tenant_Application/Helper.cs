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
        public static string CnnVal(string name)
        {
            //accessing the connection string from the config manager
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
