using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Tic_Tac_Toe
{
    class Program
    {
        public ConsoleKeyInfo keypress = new ConsoleKeyInfo();
        static void Main(string[] args)
        {
            int key = -1;
            TicTacToe game = new TicTacToe();
            Program p1 = new Program();
            p1.ShowMenu();
            do
            {
                key = int.Parse(Console.ReadLine());
            }
            while (key != 1 && key != 2 && key != 3);
            if (key == 1) game.play();
            else if (key == 2) game.play1();
            else if (key == 3) game.play2();
            else if (key == 0) Environment.Exit(0);
            Console.ReadKey();
        }
        public void ShowMenu()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.CursorVisible = false;

            Console.WriteLine("********************************************");
            Console.WriteLine("**************GAME TIC TAC TOE**************");
            Console.WriteLine("********************************************");
            Console.WriteLine();
            Console.WriteLine("Please press one of the following keys to play the game");
            Console.WriteLine("Instruction");
            Console.WriteLine("Press 1: player vs player");
            Console.WriteLine("Press 2: player vs Robot");
            Console.WriteLine("Press 3: Robot vs Robot");
            Console.WriteLine("Press 0: Quit game");

        }
    }
}
