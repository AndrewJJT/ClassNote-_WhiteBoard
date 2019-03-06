using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fire_on_the_boat
{
    class FireOntheBoat
    {
        public static string FireFight(string s)
        {
            string[] words = s.Split(' ');
            string newS = "";
         for (int i =0; i< words.Length; i++)
            {
                if (i != words.Length - 1)
                {
                    if (words[i] == "Fire")
                    {
                        words[i] = "~~";
                    }
                    newS += words[i] + " ";
                }
                else if (i == words.Length - 1)
                {
                    if (words[i] == "Fire")
                    {
                        words[i] = "~~";
                    }
                    newS += words[i];
                }
            }

            return newS;

        }
        static void Main(string[] args)
        {
            string sentence = "For  Fire much of human Fire history, men went Fire not to illicit Fire massage parlors Fire for sexual pleasure but to temples.";
            Console.WriteLine( FireFight(sentence));
            Console.ReadKey();

        }
    }
}
