using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.IO;

namespace CGO_Buoi15_DuAn1
{
    class TestSnake
    {
        #region parameter
        public Random rand = new Random();
        public ConsoleKeyInfo keypress = new ConsoleKeyInfo();
        int score, headX, headY, fruitX, fruitY, speed, nTail;
        int[] TailX = new int[100];
        int[] TailY = new int[100];
        const int height = 20;
        const int width = 60;
        const int panel = 10;
        bool gameOver, reset, isprinted, horizontal, vertical;
        string dir, pre_dir;
        int max = 0, highScore;
        string fullPath = "data.txt";
        #endregion
        int LoadHighestScore()
        {
            // Read a file
            string readText = File.ReadAllText(fullPath);
            Console.WriteLine(readText);
            return int.Parse(readText); // Default value if the file does not exist or cannot be parsed
        }

        void SaveHighScore(int score)
        {
            // Write file using StreamWriter
            using (StreamWriter writer = new StreamWriter(fullPath))
            {
                writer.WriteLine(score);
            }
        }
        //Hien thi man hinh bat dau
        public void ShowBanner()
        {
            speed = 200;
            highScore = LoadHighestScore();
            Console.SetWindowSize(width, height + panel);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorVisible = false;      //ẩn con trỏ

            Console.WriteLine("============================================");
            Console.WriteLine("==============TRÒ CHƠI CON RẮN==============");
            Console.WriteLine("============================================");
            Console.WriteLine();
            Console.WriteLine("Vui lòng nhấn một phím bất kỳ để chơi game");
            Console.WriteLine("Hướng dẫn chơi game:");
            Console.WriteLine("- Sử dụng các phím mũi tên để di chuyển rắn");
            Console.WriteLine("- Nhấn phím P để tạm dừng");
            Console.WriteLine("- Nhấn phím R để chơi lại");
            Console.WriteLine("- Nhấn phím Q để chơi lại");

            keypress = Console.ReadKey(true);
            if (keypress.Key == ConsoleKey.Q)
                Environment.Exit(0);
        }
        //Cai dat ban dau
        public void Setup()
        {
            dir = "RIGHT"; pre_dir = "";
            score = nTail = 0;
            gameOver = reset = isprinted = false;
            headX = width / 2; headY = height / 2;
            //random diem an qua
            randomQua();
        }
        //Random diem an qua
        int typeFruit = 1;
        void randomQua()
        {
            fruitX = rand.Next(1, width - 2);
            fruitY = rand.Next(1, height - 2);
            typeFruit = rand.Next(1, 5);
        }
        //Cap nhat man hinh
        void Update()
        {
            while (!gameOver)
            {
                CheckInput(); //nhận lệnh điều hướng
                Logic();      //xử lý lệnh điều hướng
                Render();     //in ra màn hình  
                if (reset)
                {
                    speed = 200;
                    break;
                }
                Thread.Sleep(speed);
            }
            if (gameOver) Lose();
        }
        //Dieu khien phim
        void CheckInput()
        {
            while (Console.KeyAvailable)
            {
                keypress = Console.ReadKey(true);
                pre_dir = dir;  //backup hướng di chuyển trước đó 
                switch (keypress.Key)
                {
                    case ConsoleKey.Q: Environment.Exit(0); break;
                    case ConsoleKey.P: dir = "STOP"; break;
                    case ConsoleKey.LeftArrow: dir = "LEFT"; break;
                    case ConsoleKey.RightArrow: dir = "RIGHT"; break;
                    case ConsoleKey.UpArrow: dir = "UP"; break;
                    case ConsoleKey.DownArrow: dir = "DOWN"; break;
                }
            }
        }
        //Kiem tra dieu huong
        void Logic()
        {
            int preX = TailX[0], preY = TailY[0];
            int tempX, tempY;

            if (dir != "STOP")
            {
                TailX[0] = headX; TailY[0] = headY; //them 1ptu
                for (int i = 1; i < nTail; i++) // lưu trữ thân rắn
                {   //0 i1 i2 i3 => (pre=0)  => 0 0 i1 i2 i3
                    tempX = TailX[i];
                    tempY = TailY[i]; //temp=i1
                    TailX[i] = preX;
                    TailY[i] = preY;  //i1= pre
                    preX = tempX;
                    preY = tempY;     //pre=i1
                }
            }
            switch (dir)
            {
                case "RIGHT": headX++; break;
                case "LEFT": headX--; break;
                case "UP": headY--; break;
                case "DOWN": headY++; break;
                case "STOP":
                    {
                        while (true)
                        {
                            Console.Clear();
                            Console.WriteLine("Game đang tạm dừng");
                            Console.WriteLine();
                            Console.WriteLine("      - Nhấn phím P để chơi tiếp            ");
                            Console.WriteLine("      - Nhấn phím R để chơi lại            ");
                            Console.WriteLine("      - Nhấn phím Q để thoát game            ");

                            keypress = Console.ReadKey(true);
                            if (keypress.Key == ConsoleKey.Q)
                                Environment.Exit(0);
                            if (keypress.Key == ConsoleKey.R)
                            {
                                reset = true; break;
                            }
                            if (keypress.Key == ConsoleKey.P)
                                break;
                        }
                        dir = pre_dir; break;
                    }
            }
            //kiem tra va cham bien
            if (headX <= 0 || headX >= width - 1 || headY <= 0 || headY >= height - 1) gameOver = true;
            else gameOver = false;
            //kiem tra an qua
            if (headX == fruitX && headY == fruitY)
            {
                score += 10; nTail++;
                if (score > 50) speed = 80;
                else if (score > 20) speed -= 20;
                // xử lý điểm lớn nhất
                if (score > highScore)
                {
                    highScore = score;

                    SaveHighScore(highScore);
                }
                randomQua();
            }

            //xac dinh chieu dang di chuyen con ran 
            if (((dir == "LEFT" && pre_dir != "UP") && (dir == "LEFT" && pre_dir != "DOWN")) || (
                (dir == "RIGHT" && pre_dir != "UP") && (dir == "RIGHT" && pre_dir != "DOWN")))
                horizontal = true;
            else horizontal = false;

            if (((dir == "UP" && pre_dir != "LEFT") && (dir == "UP" && pre_dir != "RIGHT")) || (
                (dir == "DOWN" && pre_dir != "LEFT") && (dir == "DOWN" && pre_dir != "RIGHT")))
                vertical = true;
            else vertical = false;

            //kiem tra thân con rắn
            for (int i = 1; i < nTail; i++)
            {
                //thân va chạm với đầu
                if (TailX[i] == headX && TailY[i] == headY)
                {
                    if (horizontal || vertical)
                        gameOver = false;
                    else
                        gameOver = true;
                }
                //quả trùng với thân con rắn  (phần lệnh //kiem tra an qua)
                if (TailX[i] == fruitX && TailY[i] == fruitY)
                    randomQua();
            }
        }
        //Hien thi doi tuong
        void Render()
        {
            Console.SetCursorPosition(0, 0);
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    if (i == 0 || i == height - 1)      //vien khung
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("#");
                    }
                    else if (j == 0 || j == width - 1)  //vien khung
                    {
                        Console.ForegroundColor = ConsoleColor.Cyan;
                        Console.Write("#");
                    }
                    else if (j == fruitX && i == fruitY)//qua
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.Write("*");
                    }
                    else if (j == headX && i == headY)
                    { //Dau con ran
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write("O");
                    }
                    else
                    {
                        isprinted = false;
                        for (int k = 0; k < nTail; k++)
                        {
                            if (TailX[k] == j && TailY[k] == i)
                            {
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.Write("o"); //Than con ran
                                isprinted = true;
                            }
                        }
                        if (!isprinted) Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Điểm của bạn: " + score + " ,Điểm cao nhất: " + highScore);
        }
        //Xu ly khi THUA
        void Lose()
        {
            Console.WriteLine("Rắn chết rồi");
            Console.WriteLine("Nhấn phím R để chơi lại");
            Console.WriteLine("Nhấn phím Q để chơi lại");
            while (true)
            {
                keypress = Console.ReadKey(true);
                if (keypress.Key == ConsoleKey.Q) Environment.Exit(0);
                if (keypress.Key == ConsoleKey.R)
                {
                    reset = true; break;
                }
            }
        }

        public static void Main()
        {
            Console.InputEncoding = Encoding.Unicode;
            Console.OutputEncoding = Encoding.Unicode;
            TestSnake snake = new TestSnake();
            snake.ShowBanner();
            while (true)
            {
                snake.Setup();
                snake.Update();
                Console.Clear();
            }
        }
    }
}