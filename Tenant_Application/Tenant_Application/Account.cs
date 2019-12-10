using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenant_Application
{
    public class Account
    {
        public int id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string EmailAddress { get; set; }
        public string Name { get; set; }



        public string FullInfo
        {
            get 
            { 
                // "pesho123 gosho gosho@patka.com"
                return $"{ Username } { Password } ({ EmailAddress })"; 
            }
        }
        public string UsernameInfo
        {
            get
            {
                // "pesho123 gosho gosho@patka.com"
                return $"{ Username }";
            }
        }
        public string PasswordInfo
        {
            get
            {
                // "pesho123 gosho gosho@patka.com"
                return $"{ Password }";
            }
        }
        public string NameInfo
        {
            get
            {
                // "pesho123 gosho gosho@patka.com"
                return $"{ Name }";
            }
        }
    }
}
