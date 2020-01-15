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

        public Dictionary<int, string> CheckForNames(List<string> names)
        {
            Dictionary<int, string> someName = new Dictionary<int, string>();

            //Will return me only the KEY AND NAME IF THE NAME IS CONTAINED INSIDE OF THE TABLE
            //Meaning - Key: 0 (Monday), Value(alekst)
            if (names.Contains(Monday))
            {
                someName.Add(0, Monday);
            }
            if (names.Contains(Tuesday))
            {
                someName.Add(1, Tuesday);
            }
            if(names.Contains(Wednesday))
            {
                someName.Add(2, Wednesday);
            }
            if (names.Contains(Thursday))
            {
                someName.Add(3, Thursday);
            }
            if (names.Contains(Friday))
            {
                someName.Add(4, Friday);
            }
            if (names.Contains(Saturday))
            {
                someName.Add(5, Saturday);
            }
            if (names.Contains(Sunday))
            {
                someName.Add(6, Sunday);
            }
            return someName;
        }
    }
}
