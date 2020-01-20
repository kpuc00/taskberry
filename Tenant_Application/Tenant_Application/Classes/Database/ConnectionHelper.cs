using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace Tenant_Application
{
    public static class ConnectionHelper
    {
        //creating a helper with the connectin string
        public static string ConnectionValue(string name)
        {
            //accessing the connection string from the config manager
            return ConfigurationManager.ConnectionStrings[name].ConnectionString;
        }
    }
}
      