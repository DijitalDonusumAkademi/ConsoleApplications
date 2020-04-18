using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace TypesAndVariables
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello CAN");
            AltSatir("Integer");

            Console.WriteLine("Integer Number is MinValue {0},Integer Number is MaxValue {1},", int.MinValue, int.MaxValue);

            AltSatir("Long");

            Console.WriteLine("Long Number is MinValue {0},Long Number is MaxValue {1},", long.MinValue, long.MaxValue);
            AltSatir("Short");

            Console.WriteLine("Short Number is MinValue {0},Short Number is MaxValue {1},", short.MinValue, short.MaxValue);
            AltSatir("Byte");

            Console.WriteLine("Byte Number is MinValue {0},Byte Number is MaxValue {1},", byte.MinValue, byte.MaxValue);

            AltSatir("Float");

            Console.WriteLine("Float Number is MinValue {0},Float Number is MaxValue {1},", float.MinValue, float.MaxValue);
            AltSatir("Double");

            Console.WriteLine("Double Number is MinValue {0},Double Number is MaxValue {1},", double.MinValue, double.MaxValue);

            Console.ReadLine();
        }

        public static void AltSatir(string baslik)
        {
            Console.WriteLine("********---(" + baslik + ") konusu ---*******");
        }
    }
}
