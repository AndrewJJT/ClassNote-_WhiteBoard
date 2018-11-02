using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Countwords
{
    class Countwords
    {
        public static int Wordcount (string s)
        {
            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == ' '|| s[i] == '\n'|| s[i] == '\t')
                {
                    count++;
                    while (i+1< s.Length && s[i+1]== ' ')
                    {
                        i++;
                    }
                }
            }
            return count;
        }

        static void Main(string[] args)
        {
            string input = "This is my   String.  ";
            Console.WriteLine(Wordcount(input));
        }
    }
}
