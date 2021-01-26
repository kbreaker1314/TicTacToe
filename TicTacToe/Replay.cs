using System;
namespace TicTacToe
{
    class Replay
    {
        //ask player and accept input to replay the game

        static public bool PlayAgain()
        {
            Console.WriteLine("Do you want to play again? y/n");
            // if true, do-while loop still stay valid and the game will rerun until it's false
            string str = Console.ReadLine();
            if (str == "y")
            {
                Console.WriteLine("Game is restarted");
                return true;
            }
            else return false;
        }
    }
}