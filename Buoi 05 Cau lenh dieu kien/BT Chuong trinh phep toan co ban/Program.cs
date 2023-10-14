using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BT_Chuong_trinh_phep_toan_co_ban
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int a, b;
            string phep_toan;
            int luot_dem = 4;
            Console.WriteLine("Chương trình phép toán cơ bản");
        nhap_so:
            Console.WriteLine("Nhập số a, b và phép toán phép toán cộng (+), trừ (-), nhân (*), chia(/)");

            if (int.TryParse(Console.ReadLine(), out a) && int.TryParse(Console.ReadLine(), out b))
            {
                phep_toan = Console.ReadLine();
                Console.WriteLine("Số a là " + a);
                Console.WriteLine("Số b là " + b);
                switch (phep_toan)
                    {
                        case "+":
                            Console.WriteLine("phép toán là " + phep_toan);
                            Console.WriteLine("a+b=" + (a + b));
                            break;
                        case "-":
                            Console.WriteLine("phép toán là " + phep_toan);
                            Console.WriteLine("a-b=" + (a - b));
                            break;
                        case "*":
                            Console.WriteLine("phép toán là " + phep_toan);
                            Console.WriteLine("a*b=" + (a * b));
                            break;
                        case "/":
                            Console.WriteLine("phép toán là " + phep_toan);
                            Console.WriteLine("a/b=" + (a / b));
                            break;
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
            }
            Console.ReadKey();
            return;
        quy_dinh:
            Console.WriteLine("Do nhập 4 lần không hợp lệ nên ngày mai bạn vui lòng nhập lại");
            Console.ReadKey();
        }
    }
}
