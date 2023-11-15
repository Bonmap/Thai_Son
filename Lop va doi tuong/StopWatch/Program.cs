using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BTLearn05
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Time time = new Time();
            QuickSort qS = new QuickSort();
            Random rd = new Random();
            int[] arr = new int[1000];

            for (int i = 0; i < 1000; i++)
            {
                arr[i] = rd.Next(0, 100);
            }

            Console.WriteLine("Sap xep nhanh (Quick Sort) trong C#: ");
            Console.WriteLine("-------------------------------------");

            Console.WriteLine("\nIn mang ban dau: ");
            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            qS.Quick_Sort(arr, 0, arr.Length - 1);

            Console.WriteLine();
            Console.WriteLine("\nIn mang da qua sap xep: ");

            foreach (var item in arr)
            {
                Console.Write(" " + item);
            }
            Console.WriteLine();

            time.TimeRun();

            Console.ReadKey();
        }
    }
}