using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omok
{
    public class Board
    {
        public int[,] _board;
        private int[] _lastInput;
        private int _lastPlayer;

        public Board()
        {
            _board = new int[15, 15];
            _lastInput = new int[2];
            _lastPlayer = -1;
        }

        public bool AddDol(int x, int y, int player)
        {
            if (_board[x, y] == 0)
            {
                _board[x, y] = player;
                _lastInput[0] = y;
                _lastInput[1] = x;
                _lastPlayer = player;
                return true;
            }
            else return false;
        }
        
        public bool IsGameOver()
        {
            //last input 을 기준으로 위, 아래, 대각선 비교

            if (CheckCross()) 
                return true;

            throw new NotImplementedException();
        }

        private bool CheckCross()
        {
            int countX = 0,
                countY = 0;
            for (int i = -4; i < 5; i++)
            {
                if (_lastPlayer != _board[_lastInput[0] + i, _lastInput[1]])
                {
                    countX = 0;
                }
                else if (_lastPlayer == _board[_lastInput[0] + i, _lastInput[1]])
                {
                    countX++;
                }
                if (_lastPlayer != _board[_lastInput[0], _lastInput[1] + i])
                {
                    countY = 0;
                }
                else if (_lastPlayer == _board[_lastInput[0], _lastInput[1] + i])
                {
                    countY++;
                }
                if (countX >= 5 || countY >= 5) return true;
            }
            return false;
        }
        //private bool CheckDiagonal()
        //{
        //    int count;

        //    for (_lastInput[0] == _lastInput[1] &&)
        //        //if (x == y_board[x, y])
        //        //    reutnr
        //        return false;
        //    throw new NotImplementedException();
        //}

        public void ShowBoard()
        {
            for(int i = 0; i < _board.GetLength(0); i++)
            {
                for(int j = 0; j < _board.GetLength(1); j++)
                {
                    char x = (_board[i, j] == -1) ? '●' : '○';
                    Console.Write(x);
                }
                Console.Write('\n');
            }
        }
    }


}

// 쓰레기
//for(int x=0; x<15; x++)
//{
//    count = 0;
//    for(int y=1; y<15; y++)
//    {
//        if (_board[x, y] == 0) count = 0;
//        else if (y == 1 && _board[x, y - 1] == _board[x, y]) count = 2;
//        else if (_board[x, y - 1] != _board[x, y]) count = 1;
//        else if (_board[x, y - 1] == _board[x, y])
//        {
//            count++;
//            if (count == 5) return true;
//        }
//    }
//}

//for (int x = 0; x < 15; x++)
//{
//    count = 0;
//    for (int y = 1; y < 15; y++)
//    {
//        if (_board[y, x] == 0) count = 0;
//        else if (x == 1 && _board[y, x - 1] == _board[y, x]) count = 2;
//        else if (_board[y, x - 1] != _board[y, x]) count = 1;
//        else if (_board[y, x - 1] == _board[y, x])
//        {
//            count++;
//            if (count == 5) return true;
//        }
//    }
//}

// for(int x=0; x<15; x++)
//{
//    count = 0;
//    for(int y=0; y<15; y++)
//    {

//    }
//}

//return false;