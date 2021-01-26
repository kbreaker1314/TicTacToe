using System;
namespace TicTacToe
{
    internal class playAgain
    {

        static public bool PlayAgain()
        {
            Console.WriteLine("Ez win.. Do you want to run it back? y/n");
            string str = Console.ReadLine();
            if (str == "y")
            {
                return true;
            }
            else return false;
        }
    }
}