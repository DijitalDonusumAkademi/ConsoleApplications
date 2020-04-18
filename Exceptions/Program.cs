using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            //ExceptionIntro();

            try
            {
                FindRecord();
            }
            catch (RecordNotFoundException e)
            {
                Console.WriteLine(e);
            }

            Console.ReadLine();
        }

        private static void FindRecord()
        {
            string[] students = new string[3]
            {
                "Ela", "Emel", "Ebru"
            };

            if (!students.Contains("Elaa"))
            {
                throw new RecordNotFoundException("Record Not Found");
            }
            else
            {
                Console.WriteLine("Record Found");
            }
        }

        private static void ExceptionIntro()
        {
            try
            {
                string[] students = new string[3]
                {
                    "Ela", "Emel", "Ebru"
                };

                students[3] = "Emine";
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
        }
    }
}
