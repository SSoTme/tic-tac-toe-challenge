using System;
using System.Collections.Generic;
using System.Text;

namespace TicTacToe.DotNet.Lib
{
    public class TicTacToeBoard
    {
        public TicTacToeBoard()
        {
            
        }
        public void PrintConsoleBoard()
        {
            Console.WriteLine(" ---");
            for (int i = 0; i < 9; i++)
            {
                if (i % 3 == 0)
                {
                    Console.Write("-");
                }
                Console.Write("X");
                if (i % 3 == 2)
                {
                    Console.WriteLine("");
                }
            }
            Console.WriteLine();
        }
    }
}
