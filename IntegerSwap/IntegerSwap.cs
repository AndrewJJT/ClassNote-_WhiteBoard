using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerSwap
{
    public class IntegerSwap
    {
        //public static decimal CalcTotal(string name, decimal price)
        //{
        //    decimal total;
        //    switch (name)
        //    {
        //        case "Apple":
        //            total = name.Length * price;
        //            break;
        //    }
        //
        //}
        //


        public static string IntSwap(int A, int B)
        {
            A = A + B;
            B = A - B;
            A = A - B;
            return A + "," + B;
        }

        public static bool IsPrime (int n)
        {
            for (int i = 2; i<= Math.Sqrt(n); i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }
            return true;
        }






        static void Main(string[] args)
        {
        



         int A = 90071;
         int B = 10;
         IntSwap(A, B);
         Console.WriteLine($"{A} and {B} -->" + IntSwap(A,B));
         
         Console.WriteLine("Is this nubmer a prime number? " + IsPrime(A));
         
         
         Console.WriteLine("\n\tIntegerSwap.Main()\n\t...continue...");
         Console.ReadKey();
          
        }
    }
}
