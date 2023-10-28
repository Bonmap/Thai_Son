using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CGO_Buoi10_Mang2Chieu
{
    class Program
    {
        static bool isChinhPhuong(int n)
        {
            int i = (int)Math.Sqrt(n);
            return i * i == n;
        }
        static void Main(string[] args)
        {
            //ArrayList<>
            List<int> lst = new List<int>();//lst={}
            //nap du lieu tu dong 10 so
            int n = 10;
            Random rd = new Random();
            for (int i = 0; i < n; i++)
                lst.Add(rd.Next(1, 50));
            //xuat ra man hinh truoc
            Console.WriteLine(string.Join(" ", lst));
            //Q1: Xuat ra man hinh so chan?
            /**
            foreach (int item in lst)
                if (item % 2 == 0)
                    Console.Write(item + " ");
            Console.WriteLine();
            Console.WriteLine(string.Join(" ", 
                lst.Where(item => item % 2 ==0)) );
            //OOP => LINQ
            Console.WriteLine("Tong la: " + lst.Sum());
            //Tim so chinh phuong
            Console.WriteLine(string.Join(" ",
                lst.Where(item =>isChinhPhuong(item))));
            **/
            //Nhan cac so len 2
            Console.WriteLine(string.Join(" ",
                lst.Select(item => item * 2)));
            //1 2 3 4 5
            //2 2 6 4 10
            //Nhan 2 cho cac so le ???
            foreach (int item in lst)
            {
                if (item % 2 == 1)
                    Console.Write(item * 2 + " ");
                else Console.Write(item + " ");
            }
            Console.WriteLine(string.Join(" ",
                lst.Select(item => item * 2)));
            Console.WriteLine(string.Join(" ", lst.Where(item => item % 2 == 1).Select(item => item*2)));
            Console.ReadKey();
        }
    }
}