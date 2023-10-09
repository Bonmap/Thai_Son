using System;
using System.Text;

namespace Buoi_4_BT1_Hien_Thi_loi_chao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Enter your name: ");
            string yourName = Console.ReadLine();
            Console.WriteLine("Hello: " + yourName);
            Console.ReadKey();
        }   
    }
}
