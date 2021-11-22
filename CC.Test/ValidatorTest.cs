using CC.Shared;
using System;
using Xunit;

namespace CC.Test
{
    public class ValidatorTest
    {

        static Validator validator = new Validator();

        static ChessGame game = new ChessGame();

        string fen;

        bool[,] outputBoard;

        string[,] board;

        public bool DoubleArrayEquals(bool[,] arr1, bool[,] arr2)
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
        public void ValidateMove()
        {
            fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq -0 1";
            board = game.generateBoard(fen);
            outputBoard = new bool[,] { {false, false, false, false, false, false, false, false },
                                        {false, false, false, false, false, false, false, false },
                                    {false, false, false, false, false, false, false, false },
                                    {false, false, false, false, false, false, false, false },
                                    {false, false, false, false, false, false, false, false },
                                    {false, false, false, false, false, false, false, false },
                                        {false, false, false, false, false, false, false, false },
                                        {false, false, false, false, false, false, false, false }};
            Assert.True(DoubleArrayEquals(outputBoard, Validator.LegalMoves(board, 0, 0, "r")));
        }

        [Fact]
        public void ValidateMove2()
        {
            fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq -0 1";
            board = game.generateBoard(fen);
            outputBoard = new bool[,] { {false, false, false, false, false, false, false, false },
                                        {false, false, false, false, false, false, false, false },
                                    {true, false, false, false, false, false, false, false },
                                    {true, false, false, false, false, false, false, false },
                                    {false, false, false, false, false, false, false, false },
                                    {false, false, false, false, false, false, false, false },
                                        {false, false, false, false, false, false, false, false },
                                        {false, false, false, false, false, false, false, false }};
            Assert.True(DoubleArrayEquals(outputBoard, Validator.LegalMoves(board, 0, 0, "p")));
        }

        [Fact]
        public void ValidateBishop1()
        {
            fen = "rnbqkbnr/pppppppp/8/3b4/8/8/PPPPPPPP/RNBQKBNR w KQkq -0 1";
            board = game.generateBoard(fen);
            outputBoard = new bool[,] { {false, false, false, false, false, false, false, false },
                                        {false, false, false, false, false, false, false, false },
                                    {false, false, true, false, true, false, false, false },
                                    {false, false, false, false, false, false, false, false },
                                    {false, false, true, false, true, false, false, false },
                                    {false, true, false, false, false, true, false, false },
                                        {true, false, false, false, false, false, true, false },
                                        {false, false, false, false, false, false, false, false }};
            Assert.True(DoubleArrayEquals(outputBoard, Validator.LegalBishopMoves(board, 3, 3, "b")));
        }


        [Fact]
        public void ValidateKnight1()
        {
            fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq -0 1";
            board = game.generateBoard(fen);
            outputBoard = new bool[,] { {false, false, false, false, false, false, false, false },
                                        {false, false, false, false, false, false, false, false },
                                        {true, false, true, false, false, false, false, false },
                                        {false, false, false, false, false, false, false, false },
                                    {false, false, false, false, false, false, false, false },
                                    {false, false, false, false, false, false, false, false },
                                        {false, false, false, false, false, false, false, false },
                                        {false, false, false, false, false, false, false, false }};
            Assert.True(DoubleArrayEquals(outputBoard, Validator.LegaKnightlMoves(board, 0, 1, "n")));
        }

        [Fact]
        public void ValidateRook1()
        {
            fen = "rnbqkbnr/1ppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq -0 1";
            board = game.generateBoard(fen);
            outputBoard = new bool[,] { {false, false, false, false, false, false, false, false },
                                        {true, false, false, false, false, false, false, false },
                                        {true, false, false, false, false, false, false, false },
                                        {true, false, false, false, false, false, false, false },
                                        {true, false, false, false, false, false, false, false },
                                        {true, false, false, false, false, false, false, false },
                                        {true, false, false, false, false, false, false, false },
                                        {false, false, false, false, false, false, false, false }};
            Assert.True(DoubleArrayEquals(outputBoard, Validator.LegalRookMoves(board, 0, 0, "r")));
        }

        [Fact]
        public void ValidateQueen1()
        {
            fen = "rnbqkbnr/pppppppp/8/3q4/8/8/PPPPPPPP/RNBQKBNR w KQkq -0 1";
            board = game.generateBoard(fen);
            outputBoard = new bool[,] { {false, false, false, false, false, false, false, false },
                                        {false, false, false, false, false, false, false, false },
                                        {false, false, true, true, true, false, false, false },
                                        {true, true, true, x, true, true, true, true },
                                        {false, false, true, true, true, false, false, false },
                                        {false, true, false, true, false, true, false, false },
                                        {true, false, false, true, false, false, true, false },
                                        {false, false, false, false, false, false, false, false }};
            Assert.True(DoubleArrayEquals(outputBoard, Validator.LegalQueenMoves(board, 0, 0, "q")));
        }

        [Fact]
        public void ValidateKing1()
        {
            fen = "rnbqkbnr/pppppppp/8/3k4/8/8/PPPPPPPP/RNBQKBNR w KQkq -0 1";
            board = game.generateBoard(fen);
            outputBoard = new bool[,] { {false, false, false, false, false, false, false, false },
                                        {false, false, false, false, false, false, false, false },
                                    {false, false, true, true, true, false, false, false },
                                    {false, false, true, false, true, false, false, false },
                                    {false, false, true, true, true, false, false, false },
                                    {false, false, false, false, false, false, false, false },
                                        {false, false, false, false, false, false, false, false },
                                        {false, false, false, false, false, false, false, false }};
            Assert.True(DoubleArrayEquals(outputBoard, Validator.LegalKingMoves(board, 3, 3, "k")));
        }

        [Fact]
        public void ValidatePawn1()
        {
            fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq -0 1";
            board = game.generateBoard(fen);
            outputBoard = new bool[,] { {false, false, false, false, false, false, false, false },
                                        {false, false, false, false, false, false, false, false },
                                    {false, true, false, false, false, false, false, false },
                                    {false, true, false, false, false, false, false, false },
                                    {false, false, false, false, false, false, false, false },
                                    {false, false, false, false, false, false, false, false },
                                        {false, false, false, false, false, false, false, false },
                                        {false, false, false, false, false, false, false, false }};
            Assert.True(DoubleArrayEquals(outputBoard, Validator.LegalPawnMoves(board, 1, 1, "p")));
        }
    }
}
