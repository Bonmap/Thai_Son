using System;
using System.Collections.Generic;
using System.Threading;
using System.IO;
using System.Text;

namespace hinhchunhat
{
    public class Person
    {
        public enum Days
        {
            Monday,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }

        class Program
        {
            static void Main()
            {
                Console.InputEncoding = Encoding.Unicode;
                Console.OutputEncoding = Encoding.Unicode;
                // Sử dụng biến enum
                Days today = Days.Wednesday;

                // So sánh giá trị enum
                if (today == Days.Wednesday)
                {
                    Console.WriteLine("Hôm nay là thứ Tư!");
                }

                // Chuyển đổi giữa kiểu enum và kiểu số nguyên
                int dayNumber = (int)Days.Monday;
                Console.WriteLine("Monday là ngày thứ: " + dayNumber);

                // Chuyển đổi từ chuỗi sang enum
                string dayString = "Saturday";
                Days day = (Days)Enum.Parse(typeof(Days), dayString);
                Console.WriteLine("Ngày hôm qua là: " + day);

                // Duyệt qua tất cả các giá trị enum
                Console.WriteLine("Các ngày trong tuần:");
                foreach (Days d in Enum.GetValues(typeof(Days)))
                {
                    Console.WriteLine(d);
                }
                Console.ReadKey();
            }
        }
    }
    // The example displays the following output:
}

