using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TH2_Tinh_chi_so_can_nang_cua_co_the
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double chieu_cao;
            double can_nang;
            int luot_dem = 4;
            Console.WriteLine("Chương trình tính chỉ số cân nặng của cơ thể");
        nhap_so:
            Console.WriteLine("Nhập chiều cao (m) và cân nặng (kg) ");
            if (double.TryParse(Console.ReadLine(), out chieu_cao) && double.TryParse(Console.ReadLine(), out can_nang) && chieu_cao < 3 && can_nang < 300)
            {
                Console.WriteLine("chiều cao là " + chieu_cao);
                Console.WriteLine("cân nặng là " + can_nang);
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
            double bmi = can_nang / Math.Pow(chieu_cao, 2);
            bmi = Math.Round(bmi, 1);
            Console.Write("Hệ số BMI của bạn là : " + bmi);
            if (bmi < 18)
                Console.WriteLine(" (Tình trạng Thiếu cân)");
            else if (bmi < 25.0)
                Console.WriteLine(" (Tình trạng Bình thường)");
            else if (bmi < 30.0)
                Console.WriteLine(" (Tình trạng Thừa cân)");
            else
                Console.WriteLine(" (Tình trạng Béo phì)");

            Console.ReadKey();
            return;
        quy_dinh:
            Console.WriteLine("Do nhập 4 lần không hợp lệ nên ngày mai bạn vui lòng nhập lại");
            Console.ReadKey();
        }
    }
}

