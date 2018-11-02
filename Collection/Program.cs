using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Collection
{
    public  class prod
    {
        public string name, descr;
    }
    public class Program
    {
        static void Main(string[] args)
        {
            List<string> hairProducts = new List<string>()
            {

            };

            var hairproducts2 = new List<prod>
            {
                new prod() {name = "shampoo", descr = "expensive"},
                new prod() {name = "hairbrush", descr = "special"},
                new prod() {name = "scunchie", descr = "black"}
            };
        }
    }
}
