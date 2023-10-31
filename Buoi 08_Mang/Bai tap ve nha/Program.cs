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
            Console.WriteLine("Bạn muốn làm bài tập mấy (từ bài 1 đến bài 7). Ví dụ: 4");
            while (!double.TryParse(Console.ReadLine(), out bai_tap) && bai_tap <= 6)
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
                case 1: Console.WriteLine("Tính tổng các phần tử của array và list"); Baitap1(); ; break;
                case 1.2: Console.WriteLine("Tính tổng các phần tử của array và list - cách 2"); Baitap1_C2(); ; break;
                case 2: Console.WriteLine("Tìm giá trị trong array và list"); Baitap2(); break;
                case 3: Console.WriteLine("Tìm giá trị lớn nhất trong array và list"); Baitap3(); break;
                case 4: Console.WriteLine("Thêm phần tử vào array và list (10 phân tử)"); Baitap4(); break;
                case 5: Console.WriteLine("Tìm phần tử lớn nhất trong array hai chiều"); Baitap5(); break;
                case 6: Console.WriteLine("Tính tổng các số ở đường chéo chính của ma trận vuông"); Baitap6(); break;
                case 7: Console.WriteLine("Mảng hai chiều – tạo bản đồ trò chơi MineSweeper"); Baitap7(); break;
                default: Console.WriteLine("Bài tập này không tồn tại"); break;
            }
            Console.ReadKey();
        }
        static void Baitap1()
        {
            int[] array = new int[5];
            List<int> list = new List<int>();
            Random rd = new Random();

            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rd.Next(1, 10);
            }
            for (int i = 0; i < array.Length; i++)
            {
                list.Add(rd.Next(1, 10));
            }

            int tong_array = 0;
            Console.WriteLine("Các phần tử của array là:");
            foreach (int item in array)
            {
                Console.Write(item + " | ");
                tong_array += item;
            }
            Console.WriteLine("\nTổng giá trị các phần tử trong array là: " + tong_array);
            Console.WriteLine("Các phần tử của list là:");
            Console.WriteLine(string.Join(" | ", list));
            foreach (int item in list)
            {
                Console.Write(item + " | ");
            }
            Console.WriteLine("\nTổng giá trị các phần tử trong list là: " + list.Sum());
        }
        static void Baitap1_C2()
        {
            int[] array = new int[5];
            List<int> list = new List<int>();
            int luot_dem = 4;
            int luot_dem1 = 4;
            Random rd = new Random();
            Console.WriteLine("Vui lòng nhập các phần tử của array:");
            for (int i = 0; i < array.Length; i++)
                while (!int.TryParse(Console.ReadLine(), out array[i]))
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
            Console.WriteLine("Vui lòng nhập các phần tử của list:");
            int temp;
            for (int i = 0; i < array.Length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out temp))
                {
                    luot_dem--;
                    Console.WriteLine("Số bạn nhập không hợp lệ, vui lòng nhập lại (số lần nhập còn lại là " + luot_dem1 + ")");
                    if (luot_dem == 0)
                    {
                        Console.WriteLine("Bạn đã nhập quá số lần quy định");
                        Console.ReadKey();
                        return;
                    }
                }
                list.Add(temp);
            }
            int tong = 0;
            Console.WriteLine("Các phần tử trong array là:");
            foreach (int item in array)
            {
                Console.Write(item + " | ");
                tong += item;
            }
            Console.WriteLine("\nTổng giá trị các phần tử trong array là: " + tong);

            Console.WriteLine("Các phần tử trong list là:");
            foreach (int item in list)
            {
                Console.Write(item + " | ");
            }
            Console.WriteLine("\nTổng giá trị các phần tử trong list là: " + list.Sum());
        }
        static void Baitap2()
        {
            string[] sinh_vien = new string[] { "Lan", "Linh", "Hồng Nhung", "Pha Lê", "Bảo Bảo", "Minh" };
            List<string> sinh_vien1 = new List<string>() { "Lan", "Linh", "Hồng Nhung", "Pha Lê", "Bảo Bảo", "Minh" };
            string ten_sv = "abc";
            int vi_tri = -1;
            int vi_tri1 = -1;
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
            if (vi_tri != -1) Console.WriteLine("Có tên " + ten_sv + " trong array và vị trí của phần tử là: " + (vi_tri + 1));
            else Console.WriteLine("Không tìm thấy tên " + ten_sv + " trong array");

            vi_tri1 = sinh_vien1.IndexOf(ten_sv);
            if (vi_tri1 != -1) Console.WriteLine("Có tên " + ten_sv + " trong list và vị trí của phần tử là: " + (vi_tri1 + 1));
            else Console.WriteLine("Không tìm thấy tên " + ten_sv + " trong list");
        }
        static void Baitap3()
        {
            int dai_mang;
            int luot_dem = 4;
            int luot_dem1 = 4;
            int luot_dem2 = 4;
            List<int> list = new List<int>();

            Console.WriteLine("Vui lòng nhập chiều dài của array nhỏ hơn 6 (ví dụ: 4)");
            while (!int.TryParse(Console.ReadLine(), out dai_mang) || dai_mang < 2 || dai_mang > 6)
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
            int[] array = new int[dai_mang];
            Console.WriteLine("Chiều dài của array là " + dai_mang);
            Console.WriteLine("Vui lòng nhập các phần tử của array");
            for (int i = 0; i < dai_mang; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out array[i]))
                {
                    luot_dem1--;
                    Console.WriteLine("Số bạn nhập không hợp lệ, vui lòng nhập lại phần tử thứ " + (i + 1));
                    if (luot_dem1 == 0)
                    {
                        Console.WriteLine("Bạn đã nhập quá số lần quy định");
                        Console.ReadKey();
                        return;
                    }
                }
            }

            int temp;
            Console.WriteLine("Vui lòng nhập các phần tử của list");
            for (int i = 0; i < array.Length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out temp))
                {
                    luot_dem2--;
                    Console.WriteLine("Số bạn nhập không hợp lệ, vui lòng nhập lại (số lần nhập còn lại là " + luot_dem1 + ")");
                    if (luot_dem2 == 0)
                    {
                        Console.WriteLine("Bạn đã nhập quá số lần quy định");
                        Console.ReadKey();
                        return;
                    }
                }
                list.Add(temp);
            }

            int max = int.MinValue;
            for (int i = 0; i < dai_mang; i++)
            {
                if (array[i] > max) max = array[i];
            }
            Console.WriteLine("\nPhần tử lớn nhất của array là " + max);

            Console.WriteLine("\nPhần tử lớn nhất của list là " + list.Max());

        }
        static void Baitap4()
        {
            int luot_dem = 4;
            int[] array = new int[] { 10, 12, 15, 18, 22, 0, 0, 0, 0, 0 };
            List<int> list = new List<int>() { 10, 12, 15, 18, 22, 0, 0, 0, 0, 0 };
            int gia_tri = -1;
            int vi_tri;

            Console.WriteLine("Các phần tử của array là");
            for (int i = 0; i < 10; i++)
            {
                Console.Write(array[i] + " | ");
            }
            Console.WriteLine("\nCác phần tử của list là");
            foreach (int item in list)
            {
                Console.Write(item + " | ");
            }
            Console.WriteLine("\nGiá trị của phần tử bạn muốn thêm vào:");
            while (!int.TryParse(Console.ReadLine(), out gia_tri))
            {
                luot_dem--;
                Console.WriteLine("Số bạn nhập không hợp lệ, vui lòng nhập lại");
                if (luot_dem == 0)
                {
                    Console.WriteLine("Bạn đã nhập quá số lần quy định");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("Vị trí bạn muốn thêm vào (lưu ý là < hoặc = 10):");
            while (!int.TryParse(Console.ReadLine(), out vi_tri) || vi_tri > 10)
            {
                luot_dem--;
                Console.WriteLine("Số bạn nhập không hợp lệ, vui lòng nhập lại");
                if (luot_dem == 0)
                {
                    Console.WriteLine("Bạn đã nhập quá số lần quy định");
                    Console.ReadKey();
                    return;
                }
            }

            for (int i = array.Length - 1; i >= vi_tri - 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[vi_tri - 1] = gia_tri;

            Console.WriteLine("Các phẩn tử của array sau khi giá trị được thêm vào:");
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " | ");
            }

            Console.WriteLine("\nCác phẩn tử của list sau khi giá trị được thêm vào:");
            list.Insert(vi_tri - 1, gia_tri);
            foreach (int item in list)
            {
                Console.Write(item + " | ");
            }
        }
        static void Baitap5()
        {
            int luot_dem = 4;
            Random rd = new Random();
            int max = int.MinValue;
            int n, m;
            int x = -1, y = -1;
            Console.WriteLine("Vui lòng nhập số dòng của mảng hai chiều ngẫu nhiên (lớn hơn 2 và nhỏ hơn 6): ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 2 || n >= 6)
            {
                luot_dem--;
                Console.WriteLine("Số bạn nhập không hợp lệ, vui lòng nhập lại");
                if (luot_dem == 0)
                {
                    Console.WriteLine("Bạn đã nhập quá số lần quy định");
                    Console.ReadKey();
                    return;
                }
            }
            Console.WriteLine("Vui lòng nhập số cột của mảng hai chiều ngẫu nhiên (nhỏ hơn 8): ");
            while (!int.TryParse(Console.ReadLine(), out m) || m < 1 || m >= 8)
            {
                luot_dem--;
                Console.WriteLine("Số bạn nhập không hợp lệ, vui lòng nhập lại");
                if (luot_dem == 0)
                {
                    Console.WriteLine("Bạn đã nhập quá số lần quy định");
                    Console.ReadKey();
                    return;
                }
            }
            int[,] array = new int[n, m];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                    array[i, j] = rd.Next(10, 50);
            }
            Console.WriteLine("Các phần tử của array hai chiều ngẫu nhiên: ");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write(array[i, j] + " ");
                    if (array[i, j] > max)
                    {
                        max = array[i, j]; x = i; y = j;
                    }
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Phần tử lớn nhất của array hai chiều ngẫu nhiên là: " + max + " và có tọa độ là [" + x + "," + y + "]");
        }
        static void Baitap6()
        {
            int luot_dem = 4;
            Random rd = new Random();
            int n;
            Console.WriteLine("Vui lòng nhập chiều dài của ma trận vuông (nhỏ hơn 8): ");
            while (!int.TryParse(Console.ReadLine(), out n) || n < 2 || n >= 8)
            {
                luot_dem--;
                Console.WriteLine("Số bạn nhập không hợp lệ, vui lòng nhập lại");
                if (luot_dem == 0)
                {
                    Console.WriteLine("Bạn đã nhập quá số lần quy định");
                    Console.ReadKey();
                    return;
                }
            }
            int[,] array = new int[n, n];
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                    array[i, j] = rd.Next(10, 50);
            }
            Console.WriteLine("Các phần tử của ma trận vuông ngẫu nhiên: ");
            int total = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write(array[i, j] + " ");
                    if (i == j) total += array[i, j];
                }
                Console.WriteLine("");
            }
            Console.WriteLine("Tổng các số của đường chéo chính của ma trận vuông là: " + total);
        }
        static void Baitap7()
        {
            {
                string[,] map = {
            {"*", ".", ".", "."},
            {".", ".", ".", "."},
            {".", "*", ".", "*"},
            {".", "*", ".", "."}
        };
                int MAP_HEIGHT = map.GetLength(0);
                int MAP_WIDTH = map.GetLength(1);

                string[,] mapReport = new string[MAP_HEIGHT, MAP_WIDTH];
                for (int yOrdinate = 0; yOrdinate < MAP_HEIGHT; yOrdinate++)
                {
                    for (int xOrdinate = 0; xOrdinate < map.GetLength(0); xOrdinate++)
                    {
                        string curentCell = map[yOrdinate, xOrdinate];
                        if (curentCell.Equals("*"))
                        {
                            mapReport[yOrdinate, xOrdinate] = "*";
                        }
                        else
                        {
                            int[,] NEIGHBOURS_ORDINATE = {
                        {yOrdinate - 1, xOrdinate - 1}, {yOrdinate - 1, xOrdinate}, {yOrdinate - 1, xOrdinate + 1},
                        {yOrdinate, xOrdinate - 1}, {yOrdinate, xOrdinate + 1},
                        {yOrdinate + 1, xOrdinate - 1}, {yOrdinate + 1, xOrdinate}, {yOrdinate + 1, xOrdinate + 1},};

                            int minesAround = 0;
                            int length = NEIGHBOURS_ORDINATE.GetLength(0);
                            for (int i = 0; i < length; i++)
                            {
                                int xOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i, 1];
                                int yOrdinateOfNeighbour = NEIGHBOURS_ORDINATE[i, 0];

                                bool isOutOfMapNeighbour = xOrdinateOfNeighbour < 0
                                        || xOrdinateOfNeighbour == MAP_WIDTH
                                        || yOrdinateOfNeighbour < 0
                                        || yOrdinateOfNeighbour == MAP_HEIGHT;
                                if (isOutOfMapNeighbour)
                                {
                                    continue;
                                }

                                bool isMineOwnerNeighbour = map[yOrdinateOfNeighbour, xOrdinateOfNeighbour].Equals("*");
                                if (isMineOwnerNeighbour)
                                {
                                    minesAround++;
                                }
                            }

                            mapReport[yOrdinate, xOrdinate] = minesAround.ToString();
                        }
                    }
                }
                Console.WriteLine("Bản đồ trò chơi MineSweeper:");
                for (int i = 0; i < map.GetLength(0); i++)
                {
                    for (int j = 0; j < map.GetLength(1); j++)
                    {
                        Console.Write(map[i, j]);
                    }
                    Console.WriteLine(" ");
                }
                for (int yOrdinate = 0; yOrdinate < MAP_HEIGHT; yOrdinate++)
                {
                    Console.WriteLine(" ");
                    for (int xOrdinate = 0; xOrdinate < MAP_WIDTH; xOrdinate++)
                    {
                        String currentCellReport = mapReport[yOrdinate, xOrdinate];
                        Console.Write(currentCellReport);
                    }
                }
                Console.ReadLine();
            }
        }
    }
}

