using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bai_tap_ve_nha
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            double bai_tap;
            int luot_dem = 4;
            Console.WriteLine("Bạn muốn làm bài tập mấy");
            while (!double.TryParse(Console.ReadLine(), out bai_tap))
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
                case 1: Console.WriteLine("Tính tổng các phần tử của mảng - cách 1"); Baitap1(); ; break;
                case 2: Console.WriteLine("Tính tổng các phần tử của mảng - cách 2"); Baitap1_C2(); ; break;
                case 3: Console.WriteLine("Tìm giá trị trong mảng"); Baitap2(); break;
                case 4: Console.WriteLine("Tìm giá trị lớn nhất trong mảng"); Baitap3(); break;
            }
            Console.ReadKey();
        }
        static void Baitap1()
        {
            int[] mang = new int[6];
            int luot_dem = 4;
            Console.WriteLine("Vui lòng nhập các phần tử trong mảng 1 chiều (6 phần tử)");
            for (int i = 0; i < mang.Length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out mang[i]))
                {
                    luot_dem--;
                    Console.WriteLine("Số bạn nhập không hợp lệ, vui lòng nhập lại phần tử thứ " + (i + 1));
                    if (luot_dem == 0)
                    {
                        Console.WriteLine("Bạn đã nhập quá số lần quy định");
                        Console.ReadKey();
                        return;
                    }
                }
            }
            int tong = 0;
            Console.WriteLine("Bạn đã nhập các phần tử trong mảng 1 chiều là:");
            foreach (int item in mang)
            {
                Console.Write(item + " | ");
                tong += item;
            }
            Console.WriteLine("\nTổng các phần tử trong mảng 1 chiều là: " + tong);
        }
        static void Baitap1_C2()
        {
            int[] mang = new int[6];
            Random rd = new Random();
            int so_ngau_nhien = 4;
            for (int i = 0; i < mang.Length; i++)
            {
                while (mang.Contains(so_ngau_nhien))
                {
                    so_ngau_nhien = rd.Next(12, 24);
                }
                mang[i] = so_ngau_nhien;
            }
            int tong = 0;
            Console.WriteLine("Các phần tử trong mảng 1 chiều là:");
            foreach (int item in mang)
            {
                Console.Write(item + " | ");
                tong += item;
            }
            Console.WriteLine("\nTổng các phần tử trong mảng 1 chiều là: " + tong);
        }
        static void Baitap2()
        {
            string[] sinh_vien = new string[5];
            int kiem_tra_ten;
            int luot_dem = 4;
            string ten_sv = "sơn";
            int vi_tri = -1;
            Console.WriteLine("Vui lòng nhập tên các sinh viên (5 người)");
            for (int i = 0; i < sinh_vien.Length; i++)
            {
                do
                {
                    sinh_vien[i] = Console.ReadLine();
                    if (int.TryParse(sinh_vien[i], out kiem_tra_ten))
                    {
                        luot_dem--;
                        Console.WriteLine("Tên bạn nhập không hợp lệ, vui lòng nhập lại (số lần nhập còn lại là " + luot_dem + ")");
                        if (luot_dem == 0)
                        {
                            Console.WriteLine("Bạn đã nhập quá số lần quy định");
                            Console.ReadKey();
                            return;
                        }
                    }
                }
                while (int.TryParse(sinh_vien[i], out kiem_tra_ten));
            }
            Console.WriteLine("Tên của các bạn sinh viên là:");
            for (int i = 0; i < sinh_vien.Length; i++)
            {
                Console.Write(sinh_vien[i] + " | ");
                if (ten_sv == sinh_vien[i]) vi_tri = i;
            }
            Console.WriteLine("\nNhập Tên của sinh viên cần tìm là:");
            ten_sv = Console.ReadLine();
            for (int i = 0; i < sinh_vien.Length; i++)
            {
                if (ten_sv == sinh_vien[i]) vi_tri = i;
            }
            if (vi_tri != -1) Console.WriteLine("Vị trí của phần tử trong mảng 1 chiều là: " + (vi_tri + 1));
            else Console.WriteLine("Không tìm thấy tên " + ten_sv + " trong mảng");
        }
        static void Baitap3()
        {
            int luot_dem = 4;
            int dai_mang;
            
            Console.WriteLine("Vui lòng nhập chiều dài của mảng nhỏ hơn 10 (ví dụ: 6)");
            while (!int.TryParse(Console.ReadLine(), out dai_mang) || dai_mang > 10)
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
            int[] mang = new int[dai_mang];
            Console.WriteLine("Chiều dài của mảng là " + dai_mang);
            Console.WriteLine("Vui lòng nhập các phần tử của mảng");
            for (int i = 0; i < dai_mang; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out mang[i]))
                {
                    luot_dem--;
                    Console.WriteLine("Số bạn nhập không hợp lệ, vui lòng nhập lại phần tử thứ " + (i + 1));
                    if (luot_dem == 0)
                    {
                        Console.WriteLine("Bạn đã nhập quá số lần quy định");
                        Console.ReadKey();
                        return;
                    }
                }
            }
            int max=int.MinValue;
            Console.WriteLine("Các phần tử bạn đã nhập của mảng là");
            for (int i = 0; i < dai_mang; i++)
            {
                Console.Write(mang[i]+ " | ");
                if (mang[i] > max) max = mang[i];
            }
            Console.WriteLine("\nPhần tử lớn nhất của mảng là "+max);
        }
    }
}
