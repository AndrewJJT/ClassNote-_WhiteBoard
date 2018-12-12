using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BetweenExtremes
{
    class BetweenExtremes
    { 
        public static int BetweenExtreme(int[] numbers)
        {
            int min = 0, max = 0;
            if (numbers[0] <= numbers[1])
            {
                min = numbers[0]; max = numbers[1];
            }
            else if (numbers[0] >= numbers[1])
            {
                max = numbers[0]; min = numbers[1];
            }

            foreach(int element in numbers)
            {
                if (element <= min)
                {
                    min = element;
                }
                else if (element >= max)
                {
                    max = element;
                }
            }
            return max - min;
        }
        static void Main(string[] args)
        {
            int[] input = { -1, -41, -77, -100 };

            Console.WriteLine(BetweenExtreme(input)); 
        }
    }
}
