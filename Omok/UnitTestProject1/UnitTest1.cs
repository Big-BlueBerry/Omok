using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Omok;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DolAdd()
        {
            Board board = new Board();
            board.AddDol(0, 0, -1);
            board.AddDol(0, 4, -1);
            board.AddDol(0, 3, -1);
            board.AddDol(0, 2, -1);
            board.AddDol(0, 1, -1);

            var result = new int[15, 15];
            result[0, 0] = -1;
            result[0, 1] = -1;
            result[0, 2] = -1;
            result[0, 3] = -1;
            result[0, 4] = -1;
            
            for (int i=0;i<15;i++)
            {
                for(int j=0;j<15;j++)
                {
                    Assert.AreEqual(board._board[i, j], result[i, j]);
                }
            }
        }

        [TestMethod]
        public void GameOver()
        {
            Board board = new Board();
            board.AddDol(0, 0, -1);
            board.AddDol(0, 4, -1);
            board.AddDol(0, 3, -1);
            board.AddDol(0, 2, -1);
            board.AddDol(0, 1, -1);

            Assert.AreEqual(board.IsGameOver(), true);
        }
    }
}
