using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwapIntToRNum
{
    class SwapIntRNum
    {
        //change 1, 2, 3 ,4 ,5 6, 7, 8, 9, 10 to I,II, III, IV, V, VI, VII....
        //it is actually a fixed array 

        public static string IntToRnum (int number) 
        {
            //string OnetoThree = "I", four = "IV", five = "V", ten = "X", fity = "L", hundred = "C";
            string newstring = "";
            string[] RomanNum = {"M","CM", "D","CD","C", "XC", "L", "XL", "X", "IX", "V", "IV","I" };
            int[] numberset = { 1000, 900, 500,400,100, 90, 50, 40, 10, 9, 5, 4, 1 };

            if (number <1 || number > 3999)
            {
                throw new InvalidOperationException("Roman's brains can't handle this...try new number");
            }
             
            int i = 0;
            while (number > 0)
            {
                if (number >= numberset[i])
                {
                    newstring += RomanNum[i];
                    number -= numberset[i];
                }
                else i++;
            }
            return newstring;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(IntToRnum(385));
            Console.WriteLine("\n\t Int To Roman NUmberial ()\n\t...continue...");
            Console.ReadKey();
        }
    }
}
