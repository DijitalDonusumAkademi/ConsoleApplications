using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = "Diyarbakır";

            foreach (char c in city)
            {
                Console.WriteLine(c);
            }

            string ulke1 = "TR";
            string ulke2 = "GER";

            Console.WriteLine(ulke2+"-"+ulke1);
            Console.WriteLine("----------------------");

            string name = "Microsot Visual Studio";
            var result = name.Length;
            var result2 = name.Clone();
            bool result3 = name.EndsWith("a");
            bool result4 = name.StartsWith("Microsot");

            var result6 = name.Insert(0, "Development Environment ");
            var result7 = name.Substring(3, 4);

            var result5 = name.IndexOf("Visa");

            Console.WriteLine(result7);

            Console.ReadLine();

        }
    }
}
