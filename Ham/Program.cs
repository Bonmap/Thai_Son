using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ham
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            int bai_tap;
            int luot_dem = 4;
            Console.WriteLine(@"Bài 1: Chương trình chuyển đổi nhiệt độ 
Bài 2: Tìm giá trị nhỏ nhất trong mảng sử dụng phương thức
Bài 3: Viết phương thức xoá phần tử khỏi mảng 
Bài 4: Viết phương thức đếm số lần xuất hiện của ký tự trong chuỗi");

            Console.WriteLine("Bạn muốn làm bài tập mấy (từ bài 1 đến bài 4). Ví dụ: 4");
            while (!int.TryParse(Console.ReadLine(), out bai_tap) || bai_tap >= 5)
            {
                luot_dem--;
                Console.WriteLine("Số bài tập bạn nhập không hợp lệ, vui lòng nhập lại (số lần nhập còn lại là " + luot_dem + ")");
                if (luot_dem == 0)
                {
                    Console.WriteLine("Bạn đã nhập quá số lần quy định");
                    Console.ReadKey();
                    return;
                }
            }
            switch (bai_tap)
            {
                case 1: Baitap1(); ; break;
                case 2: Baitap2(); ; break;
                case 3: Baitap3(); ; break;
                case 4: Baitap4(); ; break;
            }
            Console.ReadKey();
        }
        static void Baitap1()
        {
            double Do_c;
            double Do_f;
            int lua_chon;
            do
            {
                Console.WriteLine("Chương trình chuyển đổi nhiệt độ");
                Console.WriteLine("Menu.");
                Console.WriteLine("1. Độ F sang độ C");
                Console.WriteLine("2. Độ C sáng độ F");
                Console.WriteLine("0. Thoát chương trình");
                Console.WriteLine("Bạn chọn hình thức nào: ");
                lua_chon = int.Parse(Console.ReadLine());
                if (lua_chon > 2)
                {
                    Console.WriteLine("Bạn đã nhập ngoài giá trị của chương trình, vui lòng nhập lại");
                }
                else
                {
                    switch (lua_chon)
                    {
                        case 1:
                            Console.WriteLine("Vui lòng số Độ F:");
                            Do_f = int.Parse(Console.ReadLine());
                            Console.WriteLine(Do_f + " Độ F tương đương " + Do_F_thanh_Do_C(Do_f) + " Độ C");
                            break;
                        case 2:
                            Console.WriteLine("Vui lòng số Độ C:");
                            Do_c = int.Parse(Console.ReadLine());
                            Console.WriteLine(Do_c + " Độ C tương đương " + Do_C_thanh_Do_F(Do_c) + " Độ F");
                            break;
                        case 0:
                            Environment.Exit(0);
                            break;
                    }
                }
            } while (lua_chon != 0);
        }
        public static double Do_F_thanh_Do_C(double Do_f)
        {
            double Do_c = (5.0 / 9) * (Do_f - 32);
            return Math.Round(Do_c, 2);
        }
        public static double Do_C_thanh_Do_F(double Do_c)
        {
            double Do_f = (9.0 / 5) * Do_c + 32;
            return Do_f;
        }
        static void Baitap2()
        {
            int[] mang = { 4, 12, 7, 8, -2, 19, 9 };
            int vi_tri = Gia_tri_nho_nhat_mang(mang);
            Console.WriteLine("Các phần tử của mảng là:");
            Console.WriteLine(string.Join(" | ", mang));
            Console.WriteLine("Phần tử nhỏ nhất của mảng là: " + mang[vi_tri]);
        }
        static int Gia_tri_nho_nhat_mang(int[] mang)
        {
            int min = mang[0];
            int vi_tri = 0;

            for (int i = 1; i < mang.Length; i++)
            {
                if (mang[i] < min)
                {
                    min = mang[i];
                    vi_tri = i;
                }
            }
            return vi_tri;
        }
        static void Baitap3()
        {
            int[] mang = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int socanxoa = -1;
            int luot_dem = 4;
            Console.WriteLine("Các phần tử của mảng trước khi xóa");
            Console.WriteLine(string.Join(" | ", mang));
            Console.WriteLine("Vui lòng nhập số cần xóa ra khỏi mảng");
            while (!int.TryParse(Console.ReadLine(), out socanxoa))
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
            Console.WriteLine("");
            xoa_phan_tu_mang(mang, socanxoa);
        }
        static void xoa_phan_tu_mang(int[] mang, int socanxoa)
        {
            int vitricanxoa = 0;
            int i;

            for (i = 0; i < mang.Length; i++)
            {
                if (mang[i] == socanxoa) vitricanxoa = i;
            }

            if (vitricanxoa == 0)
            {
                Console.WriteLine("Không tìm thấy số cần xóa");
                return;
            }

            for (i = vitricanxoa; i < mang.Length - 1; i++)
            {
                mang[i] = mang[i + 1];
            }
            mang[mang.Length - 1] = 0;
            Console.WriteLine("Các phần tử của mảng sau khi đã xóa");
            Console.WriteLine(string.Join(" | ", mang));
        }
        static void Baitap4()
        {
            char kytutim;
            int luot_dem = 4;
            Console.WriteLine("Vui lòng Nhập một chuỗi");
            string chuoi = Console.ReadLine();
            Console.WriteLine("Vui lòng nhập ký tự cần đếm. Lưu ý: chỉ 1 ký tự");
            while (!char.TryParse(Console.ReadLine(), out kytutim))
            {
                luot_dem--;
                Console.WriteLine("Bạn nhập không hợp lệ, vui lòng nhập chỉ 1 ký tự (số lần nhập còn lại là " + luot_dem + ")");
                if (luot_dem == 0)
                {
                    Console.WriteLine("Bạn đã nhập quá số lần quy định");
                    Console.ReadKey();
                    return;
                }
            }
            if (Demsolanxuathienkytu(chuoi, kytutim) == 0) Console.Write("ký tự không tồn tại trong chuỗi");
            else
            {
                Console.Write("Số lần xuất hiện của ký tự " + kytutim + " là: ");
                Console.WriteLine(Demsolanxuathienkytu(chuoi, kytutim));
            }
        }

        static int Demsolanxuathienkytu(string chuoi, char kytutim)
        {
            int dem = 0;
            for (int i = 0; i < chuoi.Length; i++)
            {
                if (chuoi[i] == kytutim) dem++;
            }
            return dem;
        }
    }
}
