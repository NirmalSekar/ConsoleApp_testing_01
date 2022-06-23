using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Succesfully pushed to the Github");
           

            string name, surname;

            Console.WriteLine("Enter your name : ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your last name: ");
            surname = Console.ReadLine();

            Console.WriteLine("Your name is {0} , your surname is {1}", name, surname);


            Console.WriteLine($"this type of output can also be displayed{name}, {surname}");
            Console.ReadKey();
        }
    }
}
