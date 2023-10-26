using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mang_2_chieu
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rd = new Random();
            int n = 3;
            int m = 3;
            int[,] mang = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                mang[i, j] = rd.Next(1,50);
            }
            Console.WriteLine("Cac phan tu cua mang 2 chieu la: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(mang[i, j]+ " ");
                }
                Console.WriteLine("");
            }

            Console.ReadKey();
        }
    }
}
