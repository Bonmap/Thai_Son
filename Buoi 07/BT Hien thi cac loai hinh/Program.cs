using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Hien_thi_cac_loai_hinh
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice = -1;
            while (choice != 4)
            {
                Console.WriteLine(@"Menu
1.Print the rectangle 
2.Print the square triangle(The corner is square at 4 different angles: top - left, top - right, botton - left, botton - right
3.Print isosceles triangle
4.Exit");
                choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.WriteLine("Enter width");
                        int width = int.Parse(Console.ReadLine());
                        Console.WriteLine("Enter length");
                        int length = int.Parse(Console.ReadLine());
                        for (int i = 0; i < width; i++)
                        {
                            for (int j = 0; j < length; j++)
                            { Console.Write("*"); }
                            Console.WriteLine("");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the side length");
                        length = int.Parse(Console.ReadLine());
                        int temp = length;
                        Console.WriteLine("The corner is top-left");
                        for (int i = 0; i < length; i++)
                        {
                            for (int j = 0; j < temp; j++)
                            { Console.Write("*"); }
                            temp--;
                            Console.WriteLine("");
                        }
                        Console.WriteLine("The corner is top-right");
                        int temp1 = length;
                        for (int i = 0; i < length; i++)
                        {
                            int spaceCount = length - temp1;
                            for (int j = 0; j < spaceCount; j++)
                            { Console.Write(" "); }
                            for (int k = 0; k < temp1; k++)
                            { Console.Write("*"); }
                            temp1--;
                            Console.WriteLine("");
                        }
                        Console.WriteLine("The corner is botton-left");
                        int temp2 = length - (length - 1);
                        for (int i = 0; i < length; i++)
                        {
                            for (int j = 0; j < temp2; j++)
                            { Console.Write("*"); }
                            temp2++;
                            Console.WriteLine("");
                        }
                        Console.WriteLine("The corner is botton-right");
                        int temp3 = length;
                        for (int i = 0; i < length; i++)
                        {
                            int sao = length - temp3 + 1;
                            for (int j = 0; j < (temp3 - 1); j++)
                            { Console.Write(" "); }
                            for (int k = 0; k < sao; k++)
                            { Console.Write("*"); }
                            temp3--;
                            Console.WriteLine("");
                        }
                        break;
                    case 3:
                        Console.WriteLine("Enter the side length");
                        int n = int.Parse(Console.ReadLine());
                        for (int i = 0; i < n; i++)
                        {
                            for (int j = 0; j < n - i - 1; j++)
                            { Console.Write(" "); }
                            for (int j = 0; j < 2 * (i + 1) - 1; j++)
                            { Console.Write("*"); }
                            Console.WriteLine("");
                        }
                        break;
                    case 4:
                        {Environment.Exit(0);}
                        break;
                    default:
                        Console.WriteLine("No choice!");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
