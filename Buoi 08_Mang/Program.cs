using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Buoi_08_Mang
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int a = 10;
            int[] mang = new int[a];
            int so_ngau_nhien = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                so_ngau_nhien = rd.Next(12, 24);
                if (mang.Contains(so_ngau_nhien)) i--;
                else mang[i] = so_ngau_nhien;
            }
            Console.WriteLine("Cac phan tu cua mang la:");
            for (int i = 0; i < mang.Length; i++)
                Console.Write(mang[i] + " ");
            Console.WriteLine(" ");
            Console.WriteLine("Cac so nguyen to cua mang la:");
            int scp = 0;
            for (int i = 0; i < mang.Length; i++)
            {
                if (mang[i] > 1)
                {
                    if (mang[i] == 2 || mang[i] == 3)
                    {
                        Console.Write(mang[i]);
                    }
                    else
                    {
                        if (mang[i] % 2 != 0)
                        {
                            bool flat = true;
                            for (int j = 3; j * j <= mang[i]; j++)
                            {
                                if (mang[i] % j == 0)
                                {
                                    flat = false;
                                }
                            }
                            if (flat == true) Console.Write(mang[i] + " ");
                        }
                    }
                }

                //Console.WriteLine(" ");
                //foreach (int item in mang)
                //    Console.Write(item + " ");
                //Console.WriteLine(" ");
                //string result = string.Join(" ", mang);
                //Console.WriteLine(result);
                int b = (int)Math.Sqrt(mang[i]);
                if (b * b == mang[i]) scp++;
            }
            Console.WriteLine("\nSo luong so chinh phuong cua mang la: " + scp);
            Console.WriteLine("Them mot gia tri vao mot vi tri bat ky:");
            Console.WriteLine("Nhap vao gia tri them vao");
            int c = -1;
            int vi_tri;
            c = int.Parse(Console.ReadLine());
            Console.WriteLine("Nhap vao vi tri them vao");
            vi_tri = int.Parse(Console.ReadLine());
            mang[vi_tri - 1] = c;
            Console.WriteLine("Mang sau khi them gia tri vao vi tri " + vi_tri);
            foreach (int item in mang)
            {
                Console.Write(item + " | ");
            }
            Console.ReadKey();
        }
    }
}
