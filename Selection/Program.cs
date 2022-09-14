using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Selection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("What pizza would you like: ");
            string pizza = Console.ReadLine().ToLower();

            switch(pizza)
            {
                case "cheese and tomato":
                case "margherita":
                    Console.WriteLine("Suitable for vegetarians");
                    break;
                case "meat feast":
                case "pepperoni":
                    Console.WriteLine("Not suitable for vegetarians");
                    break;
                default:
                    Console.WriteLine("Unknown pizza!");
                    break;
            }
        }
    }
}
