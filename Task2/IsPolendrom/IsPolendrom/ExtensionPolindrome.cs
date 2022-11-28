using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsPolendrom
{
    public static class ExtensionPolindrome
    {
        public static bool CheckPolindrome(this int value)
        {
            int lastnum = value;
            int remainder = 0;
            int reverse = 0;
            while (value > 0)
            {
                remainder = value % 10;
                reverse = reverse * 10 + remainder;
                value = value / 10;
            }
            if (lastnum == reverse)
            {
                Console.WriteLine($"{lastnum} is polindrome");
                return true;
            }
            else
            {
                Console.WriteLine($"{lastnum} is not polindrome");
                return false;
            }
        }
    }
}
