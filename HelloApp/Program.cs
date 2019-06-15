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
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            Console.Write("Enter your surname: ");
            string surname = Console.ReadLine();
            Console.Write("Enter your nickname: ");
            string nickname = Console.ReadLine();
            Console.Write("How old are you: ");
            string age = Console.ReadLine();

            Console.WriteLine($"\tHello \n\t{name} {surname} aka\"{nickname}\" \n\t{age} years old ");
            Console.ReadKey();
        }
    }
}
