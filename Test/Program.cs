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
            int a, b;
            Console.WriteLine("Vui long nhap so a");
            a = int.Parse(Console.ReadLine());
            Console.WriteLine("Vui long nhap so b");
            b = int.Parse(Console.ReadLine());
            swap(ref a, ref b);
            Console.WriteLine("Sau khi hoan doi thi a se thanh "+a+ "va b thanh "+b);
            Console.ReadKey();
        }   
        static void swap(ref int num1, ref int num2)
        {
            int temp;
            temp = num1;
            num1 = num2;
            num2 = temp;
        }    
    }
}
