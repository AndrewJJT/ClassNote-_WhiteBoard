using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class ReverseNumber
    {
        public static string ReverNum (int input)
        {
            string temp = "";
            while (input > 0)
            {
                if (input > 10)
                {
                    int remainder = input % 10;
                    temp += remainder.ToString();
                    input = (input - remainder) / 10;
                }
                else
                {
                    
                    temp += input.ToString();
                    input = 0;
                }
                
            }
            return temp;
        }
        static void Main(string[] args)
        {

            int input = 56214799;
            Console.WriteLine($" The reverse of {input} is {ReverNum(input)}");
        }
    }
}
