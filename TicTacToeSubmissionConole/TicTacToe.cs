using System;
using System.Collections.Generic;
using System.Text;
using TicTacToeRendererLib.Enums;
using TicTacToeRendererLib.Renderer;

namespace TicTacToeSubmissionConole
{
    public class TicTacToe
    {
        private TicTacToeConsoleRenderer _boardRenderer;

        public TicTacToe()
        {
            _boardRenderer = new TicTacToeConsoleRenderer(10,6);
            _boardRenderer.Render();
        }

        public static string[,] position = { { "", "", "" }, { "", "", "" }, { "", "", "" } };
        public int xturn = 0;
        public int oturn = 0;
        public void Run()
        {


            while (true)
            {
                while (true)
                {
                    Console.SetCursorPosition(2, 19);

                    Console.Write("Player X");

                    Console.SetCursorPosition(2, 20);

                    Console.Write("Please Enter Row: ");
                    var row = Console.ReadLine();

                    Console.SetCursorPosition(2, 22);


                    Console.Write("Please Enter Column: ");
                    var column = Console.ReadLine();


                    // THIS JUST DRAWS THE BOARD (NO TIC TAC TOE LOGIC)

                    if (position[int.Parse(row), int.Parse(column)] == "")
                    
                    {
                        _boardRenderer.AddMove(int.Parse(row), int.Parse(column), PlayerEnum.X, true);
                        position[int.Parse(row), int.Parse(column)] = "X";
                        xturn += 1;
                        break;
                    }

                    else
                    {
                        Console.Clear();
                        Console.SetCursorPosition(2, 24);
                        Console.WriteLine("Try Again");
                    }

                }
                        // Horizontal ----------------------------------------
                    if (position[0, 0] == "X" && position[0, 1] == "X" && position[0, 2] == "X") 
                    {                        
                        Console.SetCursorPosition(3, 30);
                        Console.WriteLine("Player X Wins!!!");
                        break;
                    }
                    else if (position[1, 0] == "X" && position[1, 1] == "X" && position[1, 2] == "X")
                    {                       
                        Console.SetCursorPosition(3, 30);
                        Console.WriteLine("Player X Wins!!!");
                        break;
                    }
                    else if (position[2, 0] == "X" && position[2, 1] == "X" && position[2, 2] == "X")
                    {                    
                        Console.SetCursorPosition(3, 30);
                        Console.WriteLine("Player X Wins!!!");
                        break;
                    }

                        // Diagonal -----------------------------------------
                    else if (position[0, 0] == "X" && position[1, 1] == "X" && position[2, 2] == "X") 
                    {
                        Console.SetCursorPosition(3, 30);
                        Console.WriteLine("Player X Wins!!!");
                        break;
                    }
                    else if (position[2, 0] == "X" && position[1, 1] == "X" && position[2, 2] == "X")
                    {
                        Console.SetCursorPosition(3, 30);
                        Console.WriteLine("Player X Wins!!!");
                        break;
                    }

                        // Coloumns ------------------------------------------
                    else if (position[0, 0] == "X" && position[1, 0] == "X" && position[2, 0] == "X") 
                    {
                        Console.SetCursorPosition(3, 30);
                        Console.WriteLine("Player X Wins!!!");
                        break;
                    }
                    else if (position[0, 1] == "X" && position[1, 1] == "X" && position[2, 1] == "X")
                    {
                        Console.SetCursorPosition(3, 30);
                        Console.WriteLine("Player X Wins!!!");
                        break;
                    }
                    else if (position[0, 2] == "X" && position[1, 2] == "X" && position[2, 2] == "X")
                    {
                        Console.SetCursorPosition(3, 30);
                        Console.WriteLine("Player X Wins!!!");
                        break;
                    }



                    if (xturn == 5 & oturn == 4)
                    {
                        Console.Clear();
                        
                        Console.WriteLine("Draw!!!");
                        break;
                    }


                    while (true)
                    {

                        Console.SetCursorPosition(3, 25);

                        Console.Write("Player O");

                        Console.SetCursorPosition(3, 26);

                        Console.Write("Please Enter Row: ");
                        var row1 = Console.ReadLine();

                        Console.SetCursorPosition(3, 28);


                        Console.Write("Please Enter Column: ");
                        var column1 = Console.ReadLine();

                        if (position[int.Parse(row1), int.Parse(column1)] == "")
                        {
                            _boardRenderer.AddMove(int.Parse(row1), int.Parse(column1), PlayerEnum.O, true);
                            position[int.Parse(row1), int.Parse(column1)] = "O";
                            oturn += 1;
                            break;
                        }

                        else
                        {
                            Console.Clear();
                            Console.SetCursorPosition(2, 24);
                            Console.WriteLine("Try Again");
                        }

                            // Horizontal ----------------------------------------
                        if (position[0, 0] == "O" && position[0, 1] == "O" && position[0, 2] == "O") 
                        {
                            Console.SetCursorPosition(3, 30);
                            Console.WriteLine("Player O Wins!!!");
                            break;
                        }
                        else if (position[1, 0] == "O" && position[1, 1] == "O" && position[1, 2] == "O")
                        {
                            Console.SetCursorPosition(3, 30);
                            Console.WriteLine("Player O Wins!!!");
                            break;
                        }
                        else if (position[2, 0] == "O" && position[2, 1] == "O" && position[2, 2] == "O")
                        {
                            Console.SetCursorPosition(3, 30);
                            Console.WriteLine("Player O Wins!!!");
                            break;
                        }

                            // Diagonal -----------------------------------------
                        else if (position[0, 0] == "O" && position[1, 1] == "O" && position[2, 2] == "O") 
                        {
                            Console.SetCursorPosition(3,30);
                            Console.WriteLine("Player X Wins!!!");
                            break;
                        }
                        else if (position[2, 0] == "O" && position[1, 1] == "O" && position[2, 2] == "O")
                        {
                            Console.SetCursorPosition(3, 30);
                            Console.WriteLine("Player X Wins!!!");
                            break;
                        }

                            // Coloumns ------------------------------------------
                        else if (position[0, 0] == "O" && position[1, 0] == "O" && position[2, 0] == "O")  
                        {
                            Console.SetCursorPosition(3, 30);
                            Console.WriteLine("Player X Wins!!!");
                            break;
                        }
                        else if (position[0, 1] == "O" && position[1, 1] == "O" && position[2, 1] == "O")
                        {
                            Console.SetCursorPosition(3, 30);
                            Console.WriteLine("Player O Wins!!!");
                            break;
                        }
                        else if (position[0, 2] == "O" && position  [1, 2] == "O" && position[2, 2] == "O")
                        {
                            Console.SetCursorPosition(3, 30);
                            Console.WriteLine("Player O Wins!!!");
                            break;
                        }

                    }
            }
        }        
    }
}
