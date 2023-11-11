using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            int password;
            Console.WriteLine("Enter Username"); 
            name = Console.ReadLine();
            Console.WriteLine("Enter Password");
            password = int.Parse(Console.ReadLine());
            if(name == "admin" && password == 123)
            {
                Console.WriteLine("Enter user name : \n" + name + "\n" + "Enter password \n" + password);
                Console.WriteLine("Login successfull");
            }
            else
            {
                Console.WriteLine("Enter user name :" + name + "Enter password" + password);
                Console.WriteLine("Login failed");
            }
            Console.ReadKey();

        }
    }
}
