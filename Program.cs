using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Hash_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            string name, place, adjective, emotion;

            Console.WriteLine("Mad Lib Program by Western");

            Console.Write("Enter a name: ");
            name = Console.ReadLine();

            Console.Write("Enter a place: ");
            place = Console.ReadLine();

            Console.Write("Enter a adjective: ");
            adjective = Console.ReadLine();

            Console.Write("Enter a emotion: ");
            emotion = Console.ReadLine();

            Console.WriteLine(name + " went to the " + place + ".");
            Console.WriteLine("It was "+ adjective + "!");
            Console.WriteLine("But it was " + emotion + " that " + name + " had to go home.");

            Console.WriteLine("Press enter to exit.");

            Console.ReadLine();
        }
    }
}
