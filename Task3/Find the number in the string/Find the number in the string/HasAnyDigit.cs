using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_the_number_in_the_string
{
    public static class HasAnydDigit
    {
        public static bool HasDigit(this string value)
        {
            for (int i = 0; i < value.Length; i++)
            {
                if (char.IsDigit(value[i]))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
