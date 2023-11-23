using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Tic_Tac_Toe
{
    class Program
    {
        static void Main(string[] args)
        {
            int key = -1;
            int luot_dem = 3;
            TicTacToe game = new TicTacToe();
            ShowMenu();
            while (!int.TryParse(Console.ReadLine(), out key) || key > 3 || key < 0)
            {
                if (luot_dem > 0)
                {
                    Console.WriteLine("Error. Please select the game mode again.");
                    luot_dem--;
                }
                else
                {
                    Console.WriteLine("You have run out of options");
                    break;
                }
            }
            Console.Clear();
            if (key == 1) game.play();
            else if (key == 2) game.play1();
            else if (key == 3) game.play2();
            else if (key == 0) Environment.Exit(0);
            Console.ReadKey();

        }
        public static void ShowMenu()
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
