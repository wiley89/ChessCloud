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

        Piece[,] pieceBoard;

        string[,] board;

        [Fact]
        public void GenerateBoard()
        {
            fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq -0 1";
            pieceBoard = game.generatePieceBoard(fen);
            board = game.generateBoard(fen);
            Assert.True(board[0,0] =="br" && (pieceBoard[0,0].Type == PieceType.Rook && pieceBoard[0, 0].Color == PieceColor.Black));
        }



        [Fact]
        public void ValidateMove()
        {
            fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq -0 1";
            pieceBoard = game.generatePieceBoard(fen);
            board = game.generateBoard(fen);
            Assert.True(validator.isMoveLegal(pieceBoard[6,2], pieceBoard, fen, 6, 2, 5, 2));
        }

        [Fact]
        public void ValidateMove2()
        {
            fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq -0 1";
            pieceBoard = game.generatePieceBoard(fen);
            board = game.generateBoard(fen);
            Assert.True(validator.isMoveLegal(pieceBoard[0, 1], pieceBoard, fen, 0, 1, 2, 2));
        }

        [Fact]
        public void InvalidateMove()
        {
            fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq -0 1";
            pieceBoard = game.generatePieceBoard(fen);
            board = game.generateBoard(fen);
            Assert.False(validator.isMoveLegal(pieceBoard[0, 0], pieceBoard, fen, 0, 0, 0, 7));
        }

        [Fact]
        public void InvalidateMove2()
        {
            fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq -0 1";
            pieceBoard = game.generatePieceBoard(fen);
            board = game.generateBoard(fen);
            Assert.False(validator.isMoveLegal(pieceBoard[0, 1], pieceBoard, fen, 0, 1, 1, 3));
        }

        [Fact]
        public void InvalidateMove3()
        {
            fen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq -0 1";
            pieceBoard = game.generatePieceBoard(fen);
            board = game.generateBoard(fen);
            Assert.False(validator.isMoveLegal(pieceBoard[0, 5], pieceBoard, fen, 0, 5, 1, 3));
        }

        [Fact]
        public void ValidateBishop1()
        {
            
            Assert.True(validator.isValidBishopMove(7, 2, 6, 3));
        }

        [Fact]
        public void ValidateBishop2()
        {
            
            Assert.True(validator.isValidBishopMove(5, 5, 6, 4));
        }

        [Fact]
        public void ValidateBishop3()
        {
            
            Assert.True(validator.isValidBishopMove(5, 5, 4, 6));
        }

        [Fact]
        public void ValidateBishop4()
        {
            
            Assert.True(validator.isValidBishopMove(5, 5, 4, 4));
        }

        [Fact]
        public void ValidateBishop5()
        {
            
            Assert.True(validator.isValidBishopMove(5, 5, 3, 3));
        }

        [Fact]
        public void InvalidateBishop1()
        {
            
            Assert.False(validator.isValidBishopMove(5, 5, 5, 4));
        }

        [Fact]
        public void InvalidateBishop2()
        {
            
            Assert.False(validator.isValidBishopMove(5, 5, 7, 4));
        }

        [Fact]
        public void ValidateKnight1()
        {
            
            Assert.True(validator.isValidKnightMove(7, 2, 6, 4));
        }

        [Fact]
        public void ValidateKnight2()
        {
            
            Assert.True(validator.isValidKnightMove(5, 5, 6, 3));
        }

        [Fact]
        public void ValidateRook1()
        {
            
            Assert.True(validator.isValidRookMove(7, 2, 7, 4));
        }

        [Fact]
        public void ValidateRook2()
        {
            
            Assert.True(validator.isValidRookMove(5, 5, 6, 5));
        }

        [Fact]
        public void InvalidateRook1()
        {

            Assert.False(validator.isValidRookMove(7, 2, 6, 4));
        }

        [Fact]
        public void InvalidateRook2()
        {

            Assert.False(validator.isValidRookMove(5, 5, 6, 3));
        }

        [Fact]
        public void ValidateQueen1()
        {
            
            Assert.True(validator.isValidQueenMove(7, 2, 5, 4));
        }

        [Fact]
        public void ValidateQueen2()
        {
            
            Assert.True(validator.isValidQueenMove(5, 5, 5, 3));
        }

        [Fact]
        public void ValidateKing1()
        {
            
            Assert.True(validator.isValidKingMove(7, 2, 6, 3));
        }

        [Fact]
        public void ValidateKing2()
        {
            
            Assert.True(validator.isValidKingMove(5, 5, 6, 4));
        }

        [Fact]
        public void ValidatePawn1()
        {
            
            Assert.True(validator.isValidPawnMove(7, 2, 6, 2));
        }

        [Fact]
        public void ValidatePawn2()
        {
            
            Assert.True(validator.isValidPawnMove(5, 5, 6, 5));
        }

        [Fact]
        public void ValidatePawnEating1()
        {

            Assert.True(validator.isValidPawnEatingMove(7, 2, 6, 3));
        }

        [Fact]
        public void ValidatePawnEating2()
        {

            Assert.True(validator.isValidPawnEatingMove(5, 5, 6, 4));
        }
    }
}
