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
