using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractClasses
{
    class Program
    {
        static void Main(string[] args)
        {
            Oracle oracle=new Oracle();
            oracle.Delete();
            oracle.Add();

            SqlServer sqlServer=new SqlServer();
            sqlServer.Delete();
            sqlServer.Add();

            Console.ReadLine();
        }
    }

    abstract class Database
    {
        public void Add()
        {
            Console.WriteLine("Default ADDED");
        }

        public  abstract void Delete();
    }

    class SqlServer : Database
    {
        public override void Delete()
        {
            Console.WriteLine("SqlServer Abstract Delete");
        }
    }

    class Oracle : Database
    {
        public override void Delete()
        {
            Console.WriteLine("Oracle Abstract Delete");
        }
    }
}
