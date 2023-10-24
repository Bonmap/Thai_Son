using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            // Khởi tạo màn hình game
            Console.SetWindowSize(600, 600);

            // Khởi tạo rắn
            List<Point> snake = new List<Point>();
            snake.Add(new Point(0, 0));
            snake.Add(new Point(1, 0));

            // Khởi tạo thức ăn
            Point food = new Point(Random.Range(0, 600), Random.Range(0, 600));

            // Vòng lặp game
            while (true)
            {
                // Xử lý đầu vào
                ConsoleKeyInfo key = Console.ReadKey();

                // Di chuyển rắn
                if (key.Key == ConsoleKey.LeftArrow)
                    snake.Insert(0, new Point(snake[0].X - 1, snake[0].Y));
                else if (key.Key == ConsoleKey.RightArrow)
                    snake.Insert(0, new Point(snake[0].X + 1, snake[0].Y));
                else if (key.Key == ConsoleKey.UpArrow)
                    snake.Insert(0, new Point(snake[0].X, snake[0].Y - 1));
                else if (key.Key == ConsoleKey.DownArrow)
                    snake.Insert(0, new Point(snake[0].X, snake[0].Y + 1));

                // Xóa đuôi rắn
                snake.RemoveAt(snake.Count - 1);

                // Kiểm tra va chạm
                if (snake.Contains(food))
                {
                    // Ăn thức ăn
                    food = new Point(Random.Range(0, 600), Random.Range(0, 600));

                    // Tăng chiều dài rắn
                    snake.Add(new Point(snake[snake.Count - 1].X, snake[snake.Count - 1].Y));
                }

                // Kiểm tra va chạm với biên
                if (snake[0].X < 0 || snake[0].X >= 600 || snake[0].Y < 0 || snake[0].Y >= 600)
                {
                    // Game over
                    break;
                }

                // Kiểm tra va chạm với thân rắn
                for (int i = 1; i < snake.Count; i++)
                {
                    if (snake[0] == snake[i])
                    {
                        // Game over
                        break;
                    }
                }

                // Vẽ rắn
                for (int i = 0; i < snake.Count; i++)
                {
                    Console.SetCursorPosition(snake[i].X, snake[i].Y);
                    Console.Write("*");
                }

                // Vẽ thức ăn
                Console.SetCursorPosition(food.X, food.Y);
                Console.Write("@");

                // Dừng 1 giây
                System.Threading.Thread.Sleep(1000);
            }

            // Hiển thị thông báo game over
            Console.WriteLine("Game over!");
        }
    }
}
