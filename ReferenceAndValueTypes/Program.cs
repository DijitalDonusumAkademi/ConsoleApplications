using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReferenceAndValueTypes
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 10;
            int number2 = 21;

            number2 = number1;
            Console.WriteLine(number2);

            string[] sehirler1=new string[]{"Ankara","Diyarbakır","İstanbul"};//101
            string[] sehirler2=new string[]{"Ankara2","Diyarbakır2","İstanbul2"};//102

            sehirler2 = sehirler1;
            //sehirler2 de artık 102 adresini gösterecektir. referans yolunu gösterecektir.

            sehirler1[0] = "İzmir";

            foreach (var sehir in sehirler2)
            {
                Console.WriteLine(sehir);
            }


            Console.ReadLine();
        }
    }
}
