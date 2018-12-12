using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrintNnumberofPrime
{
    class PrintNnumberofPrime
    {
        static void CWnumberofPrime (int n)   //print out the n number of prime number example n = 4, then it would be 2,3, 5, 7
        {
            int countprime = 0;
            int value = 2;
            int counttimeofprint = 0;
            while (countprime< n)
            {
                int countnotprime = 0;

                //for (int i = 2; i < value/2; i++)  //this wont work 
                //{
                //    if (value % i != 0)
                //    {
                //        Console.WriteLine(value + " ");
                //        countprime++;
                //    }
                //}


                for (int i =2; i < value; i++)
                {
                    if (value%i == 0)
                    {
                        countnotprime++;
                        break;                      
                    }
                }
                if (countnotprime == 0)
                {
                    counttimeofprint++;
                    Console.WriteLine(value + " " + counttimeofprint);
                    countprime++;
                }

                value++;
            }
        }
        static void Main(string[] args)
        {
            CWnumberofPrime(100);
        }
    }
}
