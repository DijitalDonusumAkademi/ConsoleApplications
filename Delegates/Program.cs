using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Program
    {
        public delegate void MyDelegate();
        static void Main(string[] args)
        {
            CustomerManager customerManager=new CustomerManager();
            customerManager.SendMessage();
            customerManager.ShowAlert();


            MyDelegate myDelegate = customerManager.SendMessage;
            myDelegate += customerManager.ShowAlert;
            myDelegate-=customerManager.SendMessage;

            myDelegate();
            Console.ReadLine();
        }
    }

   public class CustomerManager
    {
        public void SendMessage()
        {
            Console.WriteLine("Hello");
        }

        public void ShowAlert()
        {
            Console.WriteLine("be careful");
        }
    }
}
