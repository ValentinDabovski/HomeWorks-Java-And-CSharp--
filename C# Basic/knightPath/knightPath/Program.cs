using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class KnightPath
{
    static void Main()
    {
        int[,] chessBoard = new int[8, 8];
        int row = 0;
        int col = chessBoard.GetLength(1) - 1;
        chessBoard[0, chessBoard.GetLength(1) - 1] = 1; //initializing the chessBoard[0, 7] cell with value of 1 in the begining
                                                        //(not in every case). Because of this initializing(in each case) test 008
                                                        //and 006 crash.
        string userInput;
        do
        {
            userInput = Console.ReadLine();
            switch (userInput)
            {
                case "left up":
                    if (col - 2 >= 0 && row - 1 >= 0)
                    {
                        //chessBoard[0, chessBoard.GetLength(1) - 1] = 1;
                        col -= 2; row -= 1;
                        if (chessBoard[row, col] == 0)
                        {
                            chessBoard[row, col] = 1;
                        }
                        else
                        {
                            chessBoard[row, col] = 0;
                        }
                    }
                    break;
                case "left down":
                    if (col - 2 >= 0 && row + 1 <= chessBoard.GetLength(0) - 1)
                    {
                        //chessBoard[0, chessBoard.GetLength(1) - 1] = 1;
                        col -= 2; row += 1;
                        if (chessBoard[row, col] == 0)
                        {
                            chessBoard[row, col] = 1;
                        }
                        else
                        {
                            chessBoard[row, col] = 0;
                        }
                    }
                    break;
                case "right up":
                    if (col + 2 <= chessBoard.GetLength(1) - 1 && row - 1 >= 0)
                    {
                        //chessBoard[0, chessBoard.GetLength(1) - 1] = 1;
                        col += 2; row -= 1;
                        if (chessBoard[row, col] == 0)
                        {
                            chessBoard[row, col] = 1;
                        }
                        else
                        {
                            chessBoard[row, col] = 0;
                        }
                    }
                    break;
                case "right down":
                    if (col + 2 <= chessBoard.GetLength(1) - 1 && row + 1 <= chessBoard.GetLength(0) - 1)
                    {
                        //chessBoard[0, chessBoard.GetLength(1) - 1] = 1;
                        col += 2; row += 1;
                        if (chessBoard[row, col] == 0)
                        {
                            chessBoard[row, col] = 1;
                        }
                        else
                        {
                            chessBoard[row, col] = 0;
                        }
                    }
                    break;
                case "up left":
                    if (row - 2 >= 0 && col - 1 >= 0)
                    {
                        //chessBoard[0, chessBoard.GetLength(1) - 1] = 1;
                        row -= 2; col -= 1;
                        if (chessBoard[row, col] == 0)
                        {
                            chessBoard[row, col] = 1;
                        }
                        else
                        {
                            chessBoard[row, col] = 0;
                        }
                    }
                    break;
                case "up right":
                    if (row - 2 >= 0 && col + 1 <= chessBoard.GetLength(1) - 1)
                    {
                        //chessBoard[0, chessBoard.GetLength(1) - 1] = 1;
                        row -= 2; col += 1;
                        if (chessBoard[row, col] == 0)
                        {
                            chessBoard[row, col] = 1;
                        }
                        else
                        {
                            chessBoard[row, col] = 0;
                        }
                    }
                    break;
                case "down left":
                    if (row + 2 <= chessBoard.GetLength(0) - 1 && col - 1 >= 0)
                    {
                        //chessBoard[0, chessBoard.GetLength(1) - 1] = 1;
                        row += 2; col -= 1;
                        if (chessBoard[row, col] == 0)
                        {
                            chessBoard[row, col] = 1;
                        }
                        else
                        {
                            chessBoard[row, col] = 0;
                        }
                    }
                    break;
                case "down right":
                    if (row + 2 <= chessBoard.GetLength(0) - 1 && col + 1 <= chessBoard.GetLength(1) - 1)
                    {
                        //chessBoard[0, chessBoard.GetLength(1) - 1] = 1;
                        row += 2; col += 1;
                        if (chessBoard[row, col] == 0)
                        {
                            chessBoard[row, col] = 1;
                        }
                        else
                        {
                            chessBoard[row, col] = 0;
                        }
                    }
                    break;
                case "stop":
                    //chessBoard[0, chessBoard.GetLength(1) - 1] = 1;
                    StringBuilder numbers = new StringBuilder();
                    for (row = 0; row < chessBoard.GetLength(0); row++)
                    {
                        for (col = 0; col < chessBoard.GetLength(1); col++)
                        {
                            numbers.Append(chessBoard[row, col]);
                        }
                    }
                    string numbersInString = numbers.ToString();

                    decimal zeroNumber = Convert.ToUInt64(numbersInString, 2);
                    if (zeroNumber == 0)
                    {
                        Console.WriteLine("[Board is empty]"); return;
                    }

                    string number1 = numbersInString.Substring(0, 8);
                    string number2 = numbersInString.Substring(8, 8);
                    string number3 = numbersInString.Substring(16, 8);
                    string number4 = numbersInString.Substring(24, 8);
                    string number5 = numbersInString.Substring(32, 8);
                    string number6 = numbersInString.Substring(40, 8);
                    string number7 = numbersInString.Substring(48, 8);
                    string number8 = numbersInString.Substring(56, 8);

                    decimal number1InDec = Convert.ToInt32(number1, 2);
                    decimal number2InDec = Convert.ToInt32(number2, 2);
                    decimal number3InDec = Convert.ToInt32(number3, 2);
                    decimal number4InDec = Convert.ToInt32(number4, 2);
                    decimal number5InDec = Convert.ToInt32(number5, 2);
                    decimal number6InDec = Convert.ToInt32(number6, 2);
                    decimal number7InDec = Convert.ToInt32(number7, 2);
                    decimal number8InDec = Convert.ToInt32(number8, 2);

                    decimal[] numbersInArray = {number1InDec, number2InDec, number3InDec, number4InDec,
                                number5InDec, number6InDec, number7InDec, number8InDec };

                    for (int i = 0; i < numbersInArray.Length; i++)
                    {
                        if (numbersInArray[i] != 0)
                        {
                            Console.WriteLine(numbersInArray[i]);
                        }
                    }
                    break;
                default:
                    break;
            }
        }
        while (userInput != "stop");
    }
}