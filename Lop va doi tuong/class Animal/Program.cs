using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace class_Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("20kg", "1.5", "kitty");
            cat.PrintInfo();
            Console.ReadKey();
        }
    }
}
