using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumofEvenNumber
{
    public class SumofEvenNumber
    {
        public static int SumofEvenNumberCal (int input1, int input2) //sum of even number between 2 numbers
        {
            int result = 0;
            for (int number = Math.Min(input1, input2); number <= Math.Max(input1, input2); number++)
            {
                if (number%2 == 0)
                {
                    result += number;
                }
            }

            return result;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(SumofEvenNumberCal(11, 4));
        }
    }
}
