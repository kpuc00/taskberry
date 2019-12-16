using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenant_Application
{
    public class Chore
    {
        public int id { get; set; }
        public string Chores { get; set; }

        public string ChoreInfo
        {
            get
            {
                return $"{ Chores }";
            }
        }

    }
}
