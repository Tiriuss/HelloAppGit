using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to C#!");
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter your nickname: ");
            string nickname = Console.ReadLine();
            Console.Write("How old are you: ");
            var age = Console.ReadLine();
            
            Console.WriteLine($"\n\tHello \n\t{name} {surname} aka\"{nickname}\" \n\t{age} years old \nLet's get ready to rumble!");
            Console.ReadKey();
        }
    }
}
