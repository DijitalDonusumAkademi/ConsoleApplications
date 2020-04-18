using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflections
{
    class Program
    {
        static void Main(string[] args)
        {
            DortIslem dortIslem1=new DortIslem(2,3);
          
            Yaz(dortIslem1.Carp(2, 5).ToString());
            Yaz(dortIslem1.Carp2().ToString());


            var type = typeof(DortIslem);
            DortIslem islem =(DortIslem)Activator.CreateInstance(type,5,6);
            Yaz(islem.Carp2().ToString());

            var instance =Activator.CreateInstance(type, 15, 16);
            Yaz(
                instance.GetType().GetMethod("Topla2").Invoke(instance, null).ToString());
            Yaz("-------------------------------------------------------------------");


            var methods = type.GetMethods();

            foreach (var method in methods)
            {
                Console.WriteLine("Metod Adı : {0}", method.Name);
                foreach (var parameter in method.GetParameters())
                {
                    Console.WriteLine(parameter.Name);
                }

                foreach (var attribute in method.GetCustomAttributes())
                {
                    Console.WriteLine(attribute.GetType().Name);

                }
            }
            Console.ReadLine();
        }

       static void Yaz(string a)
        {
            Console.WriteLine(a);
        }

        public class DortIslem
        {
            private int _a;
            private int _b;

            public DortIslem(int a, int b)
            {
                _a = a;
                _b = b;
            }

            public int Topla(int a, int b)
            {
                return a + b;
            }

            public int Carp(int a, int b)
            {
                return a * b;
            }

            public int Topla2()
            {
                return _a + _b;
            }

            public int Carp2()
            {
                return _a * _b;
            }
        }
    }
}
