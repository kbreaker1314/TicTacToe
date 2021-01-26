using System;

namespace TicTacToe
{
    class Program
    {
        
        static public string[] arr = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};

        static public void board()
        {
            Console.WriteLine("\n\n\n\t  {0}  |  {1}  |  {2}  ", arr[1], arr[2], arr[3]);
            Console.WriteLine("\n\t_ _ _ _ _ _ _ _ _  \n");
            Console.WriteLine("\t  {0}  |  {1}  |  {2}  ", arr[4], arr[5], arr[6]);
            Console.WriteLine("\n\t_ _ _ _ _ _ _ _ _  \n");
            Console.WriteLine("\t  {0}  |  {1}  |  {2} \n\n ", arr[7], arr[8], arr[9]);
        }

        static public void reset()
        {
            Console.Clear();
            board();
        }

        static public bool WinCondition()
        {
            if (arr[1] == arr[2] && arr[2] == arr[3] && arr[1] == arr[3])
            {
                return true;
            }
            if (arr[4] == arr[5] && arr[4] == arr[6] && arr[5] == arr[6])
            {
                return true;
            }
            if (arr[7] == arr[8] && arr[7] == arr[9] && arr[8] == arr[9])
            {
                return true;
            }

            if (arr[1] == arr[4] && arr[1] == arr[7] && arr[4] == arr[7])
            {
                return true;
            }
            if (arr[2] == arr[5] && arr[2] == arr[8] && arr[5] == arr[8])
            {
                return true;
            }
            if (arr[3] == arr[6] && arr[3] == arr[9] && arr[6] == arr[9])
            {
                return true;
            }

            if (arr[1] == arr[5] && arr[1] == arr[9] && arr[5] == arr[9])
            {
                return true;
            }
            if (arr[3] == arr[5] && arr[3] == arr[7] && arr[5] == arr[7])
            {
                return true;
            }
            return false;
        }
        static void Main(string[] args)
        {
            board();

            int turn = 0, choice;
            bool win = false;

            do
            {
                if (turn % 2 == 0)
                {
                    Console.Write("\nPlayer1's turn (X)\n");
                    choice = Int32.Parse(Console.ReadLine());
                    if (choice < 1 || choice > 9)
                    {
                        choice = 0;
                        turn = 0;
                        Console.WriteLine("Choose again");
                    }
                    if (choice != 0)
                    {
                        if (arr[choice] != "X" || arr[choice] != "O")
                        {

                            if (arr[choice] == "X" || arr[choice] == "O")
                            {
                                Console.WriteLine("Choose again.");
                                turn = 2;
                            }
                            else
                            {
                                arr[choice] = "X";
                                turn += 1;
                                WinCondition();
                                reset();
                                if (WinCondition() == true)
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Congrats! Player 1 won");
                                    Console.ResetColor();
                                    bool checkWin = playAgain.PlayAgain();
                                    if (checkWin == false)
                                    {
                                        win = true;
                                    }
                                    else if (checkWin == true)
                                    {
                                        for (int i = 1; i < 10; i++)
                                        {
                                            int plus2 = i;
                                            string plus = plus2.ToString();
                                            Convert.ToInt32(plus);
                                            arr[i] = plus;
                                        }
                                        turn = 0;
                                        reset();
                                    }

                                }

                            }

                        }
                    }
                }
                else if (turn % 2 == 1)
                {
                    Console.Write("\nPlayer2's turn (O)\n");
                    choice = Int32.Parse(Console.ReadLine());
                    if (choice < 1 || choice > 9)
                    {
                        choice = 0;
                        turn = 1;
                        Console.WriteLine("Choose again please");
                    }
                    if (choice != 0)
                    {
                        if (arr[choice] != "X" || arr[choice] != "O")
                        {
                            if (arr[choice] == "X" || arr[choice] == "O")
                            {
                                Console.WriteLine("Choose again.");
                                turn = 1;
                            }
                            else
                            {
                                arr[choice] = "O";
                                turn += 1;
                                WinCondition();
                                reset();
                                if (WinCondition() == true)
                                {
                                    Console.BackgroundColor = ConsoleColor.Red;
                                    Console.WriteLine("Congrats! Player 2 won");
                                    Console.ResetColor();
                                    bool checkWin = playAgain.PlayAgain();
                                    if (checkWin == false)
                                    {
                                        win = true;
                                    }
                                    else if (checkWin == true)
                                    {
                                        for (int i = 1; i < 10; i++)
                                        {
                                            int plus2 = i;
                                            string plus = plus2.ToString();
                                            Convert.ToInt32(plus);
                                            arr[i] = plus;
                                        }
                                        turn = 0;
                                        reset();
                                    }

                                }

                            }

                        }
                    }

                }

            } while (win == false);


        }
    }
}
