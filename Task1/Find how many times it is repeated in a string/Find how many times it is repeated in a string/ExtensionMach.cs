using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Find_how_many_times_it_is_repeated_in_a_string
{
    public static class ExtensionMach
    {
        public static int MatchCount(this string word, string sentence)
        {
            int count = 0;
            for (int i = 0; i < word.Length; i++)
            {
                for (int j = 0; j < word.Length - i + 1; j++)
                {
                    if (word.Substring(i, j).ToUpper() == sentence.ToUpper())
                    {
                        count++;
                    }
                }
            }
            return count;
        }
    }
}
