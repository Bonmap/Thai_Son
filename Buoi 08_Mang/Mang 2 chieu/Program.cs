using System;

namespace Mang_2_chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int n = 4;
            int m = 4;
            int[,] mang = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mang[i, j] = rd.Next(10, 30);
                }
            }
            Console.WriteLine("Cac phan tu cua mang 2 chieu la: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mang[i, j] + " ");
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Cac phan tu cua mang 2 chieu la: ");
            for (int i = 0, j = 0; i < n && j < m; j++)
            {
                Console.Write(mang[i, j] + " ");
                if (j == m - 1)
                {
                    i++;
                    j = -1;
                    Console.WriteLine("");
                }
            }
            Console.WriteLine("Cac phan tu duong cheo chinh cua mang 2 chieu la: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (i == j)
                        Console.Write(mang[i, j] + " ");
                }
            }
            Console.WriteLine("\nCac phan tu duong cheo phu cua mang 2 chieu la: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    if (j == n - 1 - i)
                        Console.Write(mang[i, j] + " ");
                }
            }
            Console.WriteLine("\ncac phan tu nua tam tren duong cheo chinh : ");
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n; j++)
                {
                    Console.Write(mang[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.WriteLine("Xuat mang 2 chieu tu mang 1 chieu: ");
            int[] mang1c = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int a = 2;
            int b = 4;
            int[,] mang2c = new int[a, b];
            for (int i = 0; i < mang1c.Length; i++)
                Console.Write(mang1c[i] + " ");
            Console.WriteLine("\nMang 2 chieu la: ");
            for (int i = 0; i < mang1c.Length; i++)
            {
                if (i < b)
                {
                    mang2c[i-i, i] = mang1c[i];
                }
                if (i >= b)
                {
                    mang2c[i-i+1, i - b] = mang1c[i];
                }
            }
            for (int i = 0; i < a; i++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write(mang2c[i, j] + " ");
                }
                Console.WriteLine(" ");
            }
            Console.ReadKey();
        }
    }
}
