using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorseCode
{
    public class Morse
    {
        static Dictionary<char, string> MorseCodeDetail = new Dictionary<char, string>()
        {
            ['A'] = ".-"
            ,
            ['B'] = "-..."
             ,
            ['C'] = "-.-."
             ,
            ['D'] = "-.."
             ,
            ['E'] = "."
             ,
            ['F'] = "..-."
             ,
            ['G'] = "--."
             ,
            ['H'] = "...."
             ,
            ['I'] = ".."
             ,
            ['J'] = ".---"
             ,
            ['K'] = "-.-"
             ,
            ['L'] = ".-.."
             ,
            ['M'] = "--"
             ,
            ['N'] = "-."
             ,
            ['O'] = "---"
             ,
            ['P'] = ".--."
             ,
            ['Q'] = "--.-"
             ,
            ['R'] = ".-."
            ,
            ['S'] = "..."
            ,
            ['T'] = "-"
            ,
            ['U'] = "..-"
            ,
            ['V'] = "...-"
            ,
            ['W'] = ".--"
            ,
            ['X'] = "-..-"
            ,
            ['Y'] = "-.--"
            ,
            ['Z'] = "--.."           
            ,
            ['0'] = "-----"
            ,
            ['1'] = ".----"
            ,
            ['2'] = "..---"
            ,
            ['3'] = "...--"
            ,
            ['4'] = "....-"
            ,
            ['5'] = "....."
            ,
            ['6'] = "-...."
            ,
            ['7'] = "--..."
            ,
            ['8'] = "---.."
            ,
            ['9'] = "----."
        };

        public static string Tx(string s)
        {
            return s;
        }

        //public static string WriteMorse (string s)
        //{
        //    char[] letters = s.ToCharArray();
        //    for (int i = 0; i < MorseCodeDetail.Count; i++)
        //    {
        //        if (MorseCodeDetail.)
        //    }
        //
        //
        //
        //
        //    foreach (KeyValuePair<char,string> element in MorseCodeDetail)
        //    {
        //        char name = element.Key;
        //        string code = element.Value;
        //        if (letters == name)
        //    }
        //}

        public static string WriteMorsebyDan (string msg, bool isSpecCode = false)
        {
            string tx = "";
            string pattern;
            msg = msg.Trim().ToUpper();
            char[] ch = msg.ToCharArray();

            foreach (char c in ch)
            {
                switch (c)
                {
                    case ' ':
                        tx += "  ";
                        break;
                    default:
                        MorseCodeDetail.TryGetValue(c, out pattern);
                        tx += pattern;
                        if (!isSpecCode) tx += ' ';
                        break;
                }
            }
            return tx;
        }
    }
}
