using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChangeMaker
{
    class Program
    {
        public static List<int> ChangeMaker(float price, List<float> payment)
        {
            //Add the input payment together
            float totalpayment = 0;
            foreach (float coinEntry in payment)
            {
                totalpayment += coinEntry;
            }
            // payment is in terms of dollar. exmaple: quarter = 0.25 dollar
            totalpayment *= 100;
            float changeIncents = totalpayment - price * 100;

            // [0] = # of pennies, [1] = # of nickels, [2] = # of dimes, [3] = # of quarter
            List<int> changeInCoins = new List<int> { 0, 0, 0, 0 };

            if (changeIncents < 0)
            {
                while (totalpayment >= 25)
                {
                    totalpayment -= 25;
                    changeInCoins[3]++;
                }
                while (totalpayment >= 10)
                {
                    totalpayment -= 10;
                    changeInCoins[2]++;
                }

                while (totalpayment >= 5)
                {
                    totalpayment -= 5;
                    changeInCoins[1]++;
                }

                while (totalpayment >= 1)
                {
                    totalpayment--;
                    changeInCoins[0]++;
                }

            }


            else
            {
                while (changeIncents >= 25)
                {
                    changeIncents -= 25;
                    changeInCoins[3]++;
                }
                while (changeIncents >= 10)
                {
                    changeIncents -= 10;
                    changeInCoins[2]++;
                }

                while (changeIncents >= 5)
                {
                    changeIncents -= 5;
                    changeInCoins[1]++;
                }

                while (changeIncents >= 1)
                {
                    changeIncents--;
                    changeInCoins[0]++;
                }

            }

            return changeInCoins;

        }



        static void Main(string[] args)
        {
            List<float> pay = new List<float> { 0.09F };
            
            foreach (float item in ChangeMaker(1.00F, pay))
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

        }
    }
}
