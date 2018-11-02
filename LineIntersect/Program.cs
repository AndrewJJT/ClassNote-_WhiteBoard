using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineIntersect
{
    class Program
    {
        public static float Intersect(int mA, int bA, int mB, int bB)
        {
            float intersectX;

            try
            {
               intersectX = (float)(bA - bB) / (mB - mA);           
            }
            catch (ArithmeticException)
            {
                Console.WriteLine("These two lines don't intersect.");
            }

            intersectX = (float)(bA - bB) / (mB - mA);
            return intersectX;
        }
        static void Main(string[] args)
        {
            Console.WriteLine(Intersect(5,5,5,5));
            Console.WriteLine();
            Console.WriteLine("\n\tIntersect()\n\t...continue...");
            Console.ReadKey();
        }
    }
}
