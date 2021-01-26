using System;
namespace TicTacToe
{
    class playAgain
    {

        static public bool PlayAgain()
        {
            Console.WriteLine("Ez win.. Do you want to run it back? y/n");
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