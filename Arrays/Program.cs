using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] mevsimler = new[]
            {
                "İlkbahar","Yaz","Sonbahar","Kış"
            };

            foreach (string mevsim in mevsimler)
            {
                Console.WriteLine(mevsim);
            }

            Console.WriteLine("--------------------------------");

            string[,] cokludizi=new string[4,3]
            {
                {"Samsung s4","Samsung s5","Samsung s6" },
                {"Lenovo A1","Lenovo A2","Lenovo A3" },
                {"IBM XE2","IBM XE6","IBM XE6" },
                {"MP Code AXX","MP Code AX2","MP Code AX4" }
            };

            for (int i = 0; i <= cokludizi.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= cokludizi.GetUpperBound(1); j++)
                {
                    Console.WriteLine(cokludizi[i,j]);
                }

                Console.WriteLine("***---***");
            }

            Console.ReadLine();
        }
    }
}
