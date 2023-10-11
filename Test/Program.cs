using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            ViDuXuatChuoi();
            //XuatChuoi();
            XuatChuoi();

            Console.ReadKey();  //tam dung man hinh
        }

        private static void ViDuXuatChuoi()
        {
            Console.WriteLine(@"Select one option: 
    Press 1 if you want to exchange VND to USD
    Press 2 if you want to exchange USD to VND");

            Console.WriteLine("Select one option: " +"\n Press 1 if you want to exchange VND to USD " +"\n Press 2 if you want to exchange USD to VND");
        }
        private static void XuatChuoi()
        {
            //a+b= ? => 2+3=5
            int a, b;
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            //C1: Ghep chuoi
            Console.WriteLine(a + " + " + b + " = " + (a + b));

            //C2: Dinh dang chuoi
            Console.WriteLine("{0} + {1} = {2}", a, b, a + b);
            Console.WriteLine("{1} + {2} = {0}", a + b, a, b);
        }
    }
}
