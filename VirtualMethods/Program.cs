using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualMethods
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlServer sqlDb=new SqlServer();
            
            sqlDb.Add();
            sqlDb.Delete();

            MySqlServer mysqlDb=new MySqlServer();
            mysqlDb.Add();
            mysqlDb.Delete();

            Console.ReadLine();
        }
    }

    class Database
    {
        public virtual void Add()
        {
            Console.WriteLine("Added");
        }

        public virtual void Delete()
        {
            Console.WriteLine("Deleted");
        }
    }

    class SqlServer : Database
    {
        public override void Add()
        {
            Console.WriteLine("Sql ADD");
        }

        public override void Delete()
        {

            Console.WriteLine("Sql Delete");
        }
    }

    class MySqlServer : Database
    {

    }
}
