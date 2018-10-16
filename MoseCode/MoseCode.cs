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
            string message = "Hello World";
            Console.WriteLine(Morse.Tx(message));
            
            //foreach (KeyValuePair<char, string>element in Morse.)
            //{
            //    char Key = element.Key;
            //    string code = element.Value;
            //    Console.WriteLine($"Letter/Number: {Key}, code: {code}");
            //}



        }
    }
}
