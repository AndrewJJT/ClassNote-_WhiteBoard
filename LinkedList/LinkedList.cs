using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class LinkedList
    {
        public static LinkedList<string> ReverseList(LinkedList<string> MyList)
        {
            var temp = MyList.First;
            while (temp.Next != null)
            {
                var nextElement = temp.Next;
                MyList.Remove(nextElement);
                MyList.AddFirst(nextElement);
            }
            return MyList;
        }
        static void Main(string[] args)
        {
            string[] name = { "Melissa", "Liu", "Cade", "RheAnna" };
            LinkedList<string> ClassAttendance = new LinkedList<string>(name);

            Console.WriteLine(ReverseList(ClassAttendance));

            //foreach (string n in ClassAttendance)
            //{
            //    Console.Write("{0} ->", n);
            //}           
            //    
            //
            //
            //Console.WriteLine();
            //ClassAttendance.AddLast("Andrew");
            //
            //foreach (string n in ClassAttendance)
            //{
            //    Console.Write("{0} ->", n);
            //}            
                
            

            Console.WriteLine();
        }
    }
}
