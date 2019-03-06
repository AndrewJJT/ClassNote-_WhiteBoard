using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MorseCode
{
    class MorseCode
    {
        static void Main(string[] args)
        {
            string message = "Hello World9";
            Console.WriteLine(Morse.Tx(message));
            //Console.ReadKey();

            //foreach (KeyValuePair<char, string>element in Morse.)
            //{
            //    char Key = element.Key;
            //    string code = element.Value;
            //    Console.WriteLine($"Letter/Number: {Key}, code: {code}");
            //}


            Console.WriteLine(Morse.WriteMorsebyDan(message));
            Console.ReadKey();
        }
    }
}
