using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omok
{
    class Program
    {
        static void Main(string[] args)
        {
            int player=-1;
            int[] Dol = new int[2];
            Board board = new Board();

            input(ref Dol);
            board.AddDol(7, 7, player);
            board.ShowBoard();

            while (board.IsGameOver())
            {
                player *= -1;
                input(ref Dol);
                while (!board.AddDol(Dol[0], Dol[1], player))
                {
                    // cls
                    Console.WriteLine("이미 그칸엔 돌이 있어여!!!");
                    input(ref Dol);
                }
                // 못넣었다고 dialog 창 만들기
                board.ShowBoard();
            }
        }

        static void input(ref int[] Dol)
        {
            String line = Console.ReadLine();
            String[] strDol = line.Split(' ');
            for (int i = 0; i < 2; i++)
            {
                Dol[i] = Int32.Parse(strDol[i]);
            }

        }
    }
}
