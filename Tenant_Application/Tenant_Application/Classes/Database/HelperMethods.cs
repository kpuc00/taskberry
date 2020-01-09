using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tenant_Application
{
    class HelperMethods
    {
        static public bool CheckIfNum(string str)
        {
            int count = 0;
            foreach (char c in str)
            {
                if (!char.IsDigit(c))
                {
                    if (count != 0 || c != '-')
                        return false;
                }
                count++;
            }
            return true;
        }

    }
}