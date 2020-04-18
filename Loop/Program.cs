using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loop
{
    class Program
    {
        static void Main(string[] args)
        {
            //forLoops();

            //whileLoop();

            //doWhileLoop();

            //forEachLoop();

            for (int i = 2; i < 10000; i++)
            {
                if (IsPrimeNumber(i))
                {
                    Console.WriteLine("Asal : "+i);
                }
                else
                {
                    Console.WriteLine("Asal değil : "+i);
                }
            }

            Console.ReadLine();

        }


        private static bool IsPrimeNumber(int number)
        {
            bool result = true;
            for (int i = 2; i < number-1; i++)
            {
                if (number%i==0)
                {
                    result=false;
                    i = number;
                }
            }

            return result;
        }

        private static void forEachLoop()
        {
            Console.WriteLine("*******************");
            String[] mevsimler = new[]
            {
                "İlkbahar", "Yaz", "Sonbahar", "Kış"
            };

            foreach (string mevsim in mevsimler)
            {
                Console.WriteLine(mevsim);
            }
        }

        private static void doWhileLoop()
        {
            Console.WriteLine("*******************");
            int i = 0;
            do
            {
                i = i + 4;
                Console.WriteLine("Sayı : " + i);
            } while (i < 100);
        }

        private static void whileLoop()
        {
            Console.WriteLine("*******************");

            int i = 0;
            while (i < 100)
            {
                Console.WriteLine("Sayı : " + i);
                i++;
            }
        }

        private static void forLoops()
        {
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine("Çift sayı :" + i);
                }

                else
                {
                    Console.WriteLine("Tek sayı :" + i);
                }
            }
        }
    }
}
