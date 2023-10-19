using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_ve_nha
{
    class Program
    {
        static void Main(string[] args)
        {
            Xuat_bang_cua_chuong();
        }
        private static void So_nguyen_to()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a;
            bool so_nguyen_to = true;
            int luot_dem = 4;
            Console.WriteLine("Chương trình kiểm tra số nguyên tố");
            Console.WriteLine("Vui lòng nhập số ");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                luot_dem--;
                if (luot_dem == 0)
                {
                    Console.WriteLine("Bạn đã nhập quá số lần quy định");
                    goto quy_dinh;
                }
                Console.WriteLine("Số bạn nhập không hợp lệ, vui lòng nhập lại (số lần nhập còn lại là " + luot_dem + ")");
            }
            Console.WriteLine("số bạn nhập là " + a);
            if (a < 2) Console.WriteLine("số " + a + " không phải là số nguyên tố");
            else
            {
                for (int i = 2; i * i < a; i++)
                {
                    if (a % i == 0) so_nguyen_to = false;
                    break;
                }
                if (so_nguyen_to) Console.WriteLine("số " + a + " là số nguyên tố");
                else Console.WriteLine("số " + a + " không phải là số nguyên tố");
            }
            Console.ReadKey();
            return;
        quy_dinh:
            Console.WriteLine("Do nhập 4 lần không hợp lệ nên ngày mai bạn vui lòng nhập lại");
            Console.ReadKey();
        }
        private static void In_so_chan_trong_khoang()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int m = -1;
            int n = -1;
            int luot_dem = 4;
            Console.WriteLine("Chương trình in ra số chẵn trong khoảng 2 số nhập vào");
            Console.WriteLine("Vui lòng nhập 2 số");
            while (!int.TryParse(Console.ReadLine(), out m) || !int.TryParse(Console.ReadLine(), out n))
            {
                luot_dem--;
                if (luot_dem == 0)
                {
                    Console.WriteLine("Bạn đã nhập quá số lần quy định");
                    goto quy_dinh;
                }
                Console.WriteLine("Số bạn nhập không hợp lệ, vui lòng nhập lại (số lần nhập còn lại là " + luot_dem + ")");
            }
            Console.WriteLine("số bạn nhập là " + m + " và " + n);
            if (m > n)
            {
                Console.WriteLine("các số chẵn là: ");
                for (int i = n; i <= m; i++)
                { if (i % 2 == 0) Console.Write(i + " "); }
            }
            else
            {
                Console.WriteLine("Các số chẵn là: ");
                for (int i = m; i <= n; i++)
                {
                    if (i % 2 == 0) Console.Write(i + " ");
                }
            }
            Console.ReadKey();
            return;
        quy_dinh:
            Console.WriteLine("Do nhập 4 lần không hợp lệ nên ngày mai bạn vui lòng nhập lại");
            Console.ReadKey();
        }
        private static void So_hoan_hao()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int m = -1;
            int luot_dem = 4;
            Console.WriteLine("Chương trình kiểm tra số hoàn hảo");
            Console.WriteLine("Vui lòng nhập số");
            while (!int.TryParse(Console.ReadLine(), out m))
            {
                luot_dem--;
                if (luot_dem == 0)
                {
                    Console.WriteLine("Bạn đã nhập quá số lần quy định");
                    goto quy_dinh;
                }
                Console.WriteLine("Số bạn nhập không hợp lệ, vui lòng nhập lại (số lần nhập còn lại là " + luot_dem + ")");

            }
            Console.WriteLine("số bạn nhập là " + m);
            Console.WriteLine("các ước số của " + m + " là: ");
            Console.Write("1 ");
            int total = 1;
            for (int i = 2; i <= m / 2; i++)
            {
                if (m % i == 0)
                {
                    Console.Write(i + " ");
                    total += i;
                }
            }
            Console.WriteLine("\nTổng các ước số của " + m + " là " + total);
            if (total == m) Console.WriteLine("yes");
            else Console.WriteLine("no");
            Console.ReadKey();
            return;
        quy_dinh:
            Console.WriteLine("Do nhập 4 lần không hợp lệ nên ngày mai bạn vui lòng nhập lại");
            Console.ReadKey();
        }
        private static void Uoc_chung_lon_nhat()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int m = -1;
            int n = -1;
            int luot_dem = 4;
            Console.WriteLine("Chương trình xuất số UCLN của 2 số");
            Console.WriteLine("Vui lòng nhập 2 số nguyên");
            while (!int.TryParse(Console.ReadLine(), out m) || !int.TryParse(Console.ReadLine(), out n))
            {
                luot_dem--;
                Console.WriteLine("Số bạn nhập không hợp lệ, vui lòng nhập lại (số lần nhập còn lại là " + luot_dem + ")");
                if (luot_dem == 0)
                {
                    Console.WriteLine("Bạn đã nhập quá số lần quy định");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("Số bạn nhập là " + m + " và " + n);
            Console.WriteLine("Các ước chung của 2 số");
            int ucln = 0;
            for (int i = 1; i <= m; i++)
            {
                for (int j = 1; j <= n; j++)
                {
                    if (m % i == 0 && n % j == 0 && i == j)
                    {
                        ucln = i;
                        Console.Write(i + " ");
                    }
                }
            }
            Console.WriteLine("\nUCLN của 2 số là " + ucln);
            Console.ReadKey();
            return;
        }
        private static void Uoc_chung_lon_nhat_2()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a = -1;
            int b = -1;
            int luot_dem = 4;
            Console.WriteLine("Chương trình xuất số UCLN của 2 số");
            Console.WriteLine("Vui lòng nhập 2 số nguyên");
            while (!int.TryParse(Console.ReadLine(), out a) || !int.TryParse(Console.ReadLine(), out b))
            {
                luot_dem--;
                Console.WriteLine("Số bạn nhập không hợp lệ, vui lòng nhập lại (số lần nhập còn lại là " + luot_dem + ")");
                if (luot_dem == 0)
                {
                    Console.WriteLine("Bạn đã nhập quá số lần quy định");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("Số bạn nhập là " + a + " và " + b);
            while (a != b)
            {
                if (a > b) a -= b;
                else b -= a;
            }
            Console.WriteLine("UCLN của 2 số là " + a);
            Console.ReadKey();
            return;
        }
        private static void tim_giai_thua_cua_mot_so()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a = -1;
            int luot_dem = 4;
            Console.WriteLine("Chương trình tìm giai thừa của một số");
            Console.WriteLine("Vui lòng nhập số nguyên");
            while (!int.TryParse(Console.ReadLine(), out a))
            {
                luot_dem--;
                Console.WriteLine("Số bạn nhập không hợp lệ, vui lòng nhập lại (số lần nhập còn lại là " + luot_dem + ")");
                if (luot_dem == 0)
                {
                    Console.WriteLine("Bạn đã nhập quá số lần quy định");
                    Console.ReadKey();
                    return;
                }
            }
            int giai_thua = 1;
            for (int i = 1; i <= a; i++)
            {
                giai_thua *= i;
            }
            Console.WriteLine("Giai thừa của " + a + " là " + giai_thua);
            Console.ReadKey();
        }
        private static void Xuat_bang_cua_chuong()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a = -1;
            int luot_dem = 4;
            Console.WriteLine("Chương trình in ra bảng cửu chương từ 1 đến 10");
            Console.WriteLine("Vui lòng nhập số nguyên từ 1 đến 10");
            while (!int.TryParse(Console.ReadLine(), out a) || a < 1 || a > 10)
            {
                luot_dem--;
                Console.WriteLine("Số bạn nhập không hợp lệ, vui lòng nhập lại (số lần nhập còn lại là " + luot_dem + ")");
                if (luot_dem == 0)
                {
                    Console.WriteLine("Bạn đã nhập quá số lần quy định");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("Bảng cửu chương của " + a + " là: ");
            for (int i = 1; i <= 10; i++)
            {
                Console.WriteLine(a + " x " + i + " = " + (a * i));
            }    
            Console.ReadKey();
        }
    }
}

