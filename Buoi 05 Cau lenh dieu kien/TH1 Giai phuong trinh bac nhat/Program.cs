using System;
using System.Text;

namespace TH1_Giai_phuong_trinh_bac_nhat
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            float a;
            float b;
            int luot_dem =4;
            Console.WriteLine("Chương trình giải phương trình bậc nhất ax+b=0");
        nhap_so:
            Console.WriteLine("Nhập số a và b");
            if (float.TryParse(Console.ReadLine(), out a) && float.TryParse(Console.ReadLine(), out b))
            {
                Console.WriteLine("Số a là " + a);
                Console.WriteLine("Số b là " + b);
            }
            else
            {
                luot_dem--;
                if (luot_dem==0)
                {
                    Console.WriteLine("Bạn đã nhập quá số lần quy định");
                    goto quy_dinh;
                }    
                Console.WriteLine("Số bạn nhập không hợp lệ, vui lòng nhập lại (số lần nhập còn lại là "+luot_dem+")");
                goto nhap_so;
            }
            if (a!=0) Console.WriteLine("Phương trình có 1 nghiệm là " + (-b) / a);
            else
            {
                if (b==0) Console.WriteLine("Phương trình vô số nghiệm");
                else Console.WriteLine("Phương trình vô nghiệm");
                
            }
            Console.ReadKey();
            return;
        quy_dinh:
            Console.WriteLine("Do nhập 4 lần không hợp lệ nên ngày mai bạn vui lòng nhập lại");
            Console.ReadKey();
        }
    }
}
