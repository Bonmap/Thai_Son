using System;
using System.Text;

namespace BT1_Ung_dung_doc_so_thanh_chu
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a;
            int luot_dem = 4;
            Console.WriteLine("Ứng dụng đọc số thành chữ (số dương có 3 chữ số)");
        nhap_so:
            Console.WriteLine("Vui lòng nhập số ");
            if (int.TryParse(Console.ReadLine(), out a) && a >= 0 & a < 1000)
            {
                int first, second, third;
                first = a / 100;
                second = a % 100 / 10;
                third = a - first * 100 - second * 10;
                Console.WriteLine("Số bạn nhập là " + first + "" + second + "" + third);
                switch (first)
                {
                    case 0:
                        Console.Write("");
                        break;
                    case 1:
                        Console.Write(" one hundred ");
                        break;
                    case 2:
                        Console.Write(" two hundred ");
                        break;
                    case 3:
                        Console.Write(" three hundred ");
                        break;
                    case 4:
                        Console.Write(" four hundred ");
                        break;
                    case 5:
                        Console.Write(" five hundred ");
                        break;
                    case 6:
                        Console.Write(" six hundred ");
                        break;
                    case 7:
                        Console.Write(" seven hundred ");
                        break;
                    case 8:
                        Console.Write(" eight hundred ");
                        break;
                    case 9:
                        Console.Write(" nine hundred ");
                        break;
                }
                if (first > 0 && third > 0) Console.Write("and");
                if (first > 0 && second > 0 && third == 0) Console.Write("and");
                if (first == 0 && second == 0 && third == 0) Console.Write("zero");
                if (second == 1)
                {
                    switch (third)
                    {
                        case 1:
                            Console.Write(" eleven ");
                            break;
                        case 2:
                            Console.Write(" twelve ");
                            break;
                        case 3:
                            Console.Write(" thirteen ");
                            break;
                        case 4:
                            Console.Write(" fourteen ");
                            break;
                        case 5:
                            Console.Write(" fifteen ");
                            break;
                        case 6:
                            Console.Write(" sixteen ");
                            break;
                        case 7:
                            Console.Write(" seventeen ");
                            break;
                        case 8:
                            Console.Write(" eighteen ");
                            break;
                        case 9:
                            Console.Write(" nineteen ");
                            break;
                    }
                    Console.ReadKey();
                    return;
                }
                switch (second)
                {
                    case 2:
                        Console.Write(" twenty ");
                        break;
                    case 3:
                        Console.Write(" thirty ");
                        break;
                    case 4:
                        Console.Write(" forty ");
                        break;
                    case 5:
                        Console.Write(" fifty ");
                        break;
                    case 6:
                        Console.Write(" sixty ");
                        break;
                    case 7:
                        Console.Write(" seventy ");
                        break;
                    case 8:
                        Console.Write(" eighty ");
                        break;
                    case 9:
                        Console.Write(" ninety ");
                        break;
                }
                if (second != 1)
                {
                    switch (third)
                    {
                        case 0:
                            Console.WriteLine(" ");
                            break;
                        case 1:
                            Console.WriteLine("one");
                            break;
                        case 2:
                            Console.WriteLine("two");
                            break;
                        case 3:
                            Console.WriteLine("three");
                            break;
                        case 4:
                            Console.WriteLine("four");
                            break;
                        case 5:
                            Console.WriteLine("five");
                            break;
                        case 6:
                            Console.WriteLine("six");
                            break;
                        case 7:
                            Console.WriteLine("seven");
                            break;
                        case 8:
                            Console.WriteLine("eight");
                            break;
                        case 9:
                            Console.WriteLine("nine");
                            break;
                    }
                    Console.ReadKey();
                    return;
                }
            }
            else
            {
                luot_dem--;
                if (luot_dem == 0)
                {
                    Console.WriteLine("Bạn đã nhập quá số lần quy định");
                    goto quy_dinh;
                }
                Console.WriteLine("Số bạn nhập không hợp lệ, vui lòng nhập lại (số lần nhập còn lại là " + luot_dem + ")");
                goto nhap_so;
                return;
            }
        quy_dinh:
            Console.WriteLine("Do nhập 4 lần không hợp lệ nên ngày mai bạn vui lòng nhập lại");
            Console.ReadKey();
        }
    }
}
