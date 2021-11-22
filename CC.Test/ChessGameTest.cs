using CC.Shared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace CC.Test
{

    public class ChessGameTest
    {
        static ChessGame game = new ChessGame();

        public bool DoubleArrayEquals(String[,] arr1, String[,] arr2)
        {
            for (int i = 0; i < arr1.GetLength(0); i++)
            {
                for (int j = 0; j < arr1.GetLength(1); j++)
                {
                    if (arr1[i, j] != arr2[i, j])
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        [Fact]
        public void GenerateBoard()
        {
            String fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq -0 1";

            string[,] board = new string[,] { {"r","n", "b", "q", "k", "b", "n", "r"},
                                              {"p","p", "p", "p", "p", "p", "p", "p"},
                                              {"em", "em", "em", "em", "em", "em", "em", "em"},
                                              {"em", "em", "em", "em", "em", "em", "em", "em"},
                                              {"em", "em", "em", "em", "em", "em", "em", "em"},
                                              {"em", "em", "em", "em", "em", "em", "em", "em"},
                                              {"P","P", "P", "P", "P", "P", "P", "P"},
                                              {"R","N", "B", "Q", "K", "B", "N", "R"} };
            Assert.True(DoubleArrayEquals(board, game.generateFen(fen)));
        }

        [Fact]
        public void GenerateFEN()
        {
            string[,] board = new string[,] { {"r","n", "b", "q", "k", "b", "n", "r"},
                                              {"p","p", "p", "p", "p", "p", "p", "p"},
                                              {"em", "em", "em", "em", "em", "em", "em", "em"},
                                              {"em", "em", "em", "em", "em", "em", "em", "em"},
                                              {"em", "em", "em", "em", "em", "em", "em", "em"},
                                              {"em", "em", "em", "em", "em", "em", "em", "em"},
                                              {"P","P", "P", "P", "P", "P", "P", "P"},
                                              {"R","N", "B", "Q", "K", "B", "N", "R"} };
            Assert.True("rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR" == game.generateFen(board));
        }
    }
}
