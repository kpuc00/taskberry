using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenant_Application
{
    public class CalendarDays
    {
        //public List<string> Monday { get; set; } = new List<string>();
        public string Monday { get; set; }
        public string Tuesday { get; set; }
        public string Wednesday { get; set; }
        public string Thursday { get; set; }
        public string Friday { get; set; }
        public string Saturday { get; set; }
        public string Sunday { get; set; }


        public string[] ShowDays()
        {
            string[] days = {"Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday"};
            return days;
        }
    }
}
