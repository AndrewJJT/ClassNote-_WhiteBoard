using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwiceOfAge
{
    public class TwiceOfAge
    {
        public static int Twice(int son, int father)
        {
            int year = 0;
            //if ((father - son) > son)
            //{
            //    while (father != 2 * son)
            //    {
            //        year++;
            //        father++;
            //        son++;
            //    }
            //    return year;
            //}
            //else if ((father - son) < son)
            //{
            //    while (father != 2 * son)
            //    {
            //        year--;
            //        father--;
            //        son--;
            //    }
            //    return year;
            //}
            //else
            //{
            //    return year;
            //}

            while (father !=2 * son)
            {
                if ((father - son) > son)
                {
                    year++;
                    father++;
                    son++;
                }
                else if ((father - son) < son)
                {
                    year--;
                    father--;
                    son--;
                }              
            }

            return year;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Math.Abs(Twice(20, 45)) + " year(s)");  
        }
    }
}
