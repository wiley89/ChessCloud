using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessCloud.Data
{
    public class ChessGame
    {
        //intitial placement

        public string FEN { get; set; }

        private static string initialFen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";
        List<Piece> whitePieces = new List<Piece>();
        List<Piece> blackPieces = new List<Piece>();

        public string[,] generateBoard(string fen)
        {
            string[,] board = new string[8, 8];
            string currentRow;
            string[] divFen = fen.Split(" ");
            string[] row = divFen[0].Split("/");
            int column = 0;

            for (int i = 0; i < 8; i++)
            {
                currentRow = row[i];
                column = 0;
                if (column < 8)
                {
                    foreach (char c in currentRow)
                    {
                        if (Char.IsDigit(c))
                        {
                            for (int j = c - '0'; j > 0; j--)
                            {
                                board[i, column] = "em";
                                column++;
                            }
                        }
                        else if (Char.IsUpper(c))
                        {
                            board[i, column] = "w" + Char.ToLower(c);
                            column++;
                        }
                        else
                        {
                            board[i, column] = "b" + c;
                            column++;
                        }
                    }
                }
            }
            //string[,] newBoard = new string[8, 8];
            return board;
        }

        public Piece[,] generatePieceBoard(string fen)
        {
            string[,] board = generateBoard(fen);
            Piece[,] pieceBoard = new Piece[8, 8];

            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (board[i, j] == "em")
                    {
                        pieceBoard[i, j] = null;
                    }
                    else if (board[i, j][0] == 'w')
                    {
                        switch (board[i, j][1])
                        {
                            case 'r':
                                pieceBoard[i, j] = new Piece()
                                {
                                    Row = i,
                                    Column = j,
                                    Type = PieceType.Rook,
                                    Color = PieceColor.White
                                };
                                break;
                            case 'n':
                                pieceBoard[i, j] = new Piece()
                                {
                                    Row = i,
                                    Column = j,
                                    Type = PieceType.Knight,
                                    Color = PieceColor.White
                                };
                                break;
                            case 'b':
                                pieceBoard[i, j] = new Piece()
                                {
                                    Row = i,
                                    Column = j,
                                    Type = PieceType.Bishop,
                                    Color = PieceColor.White
                                };
                                break;
                            case 'q':
                                pieceBoard[i, j] = new Piece()
                                {
                                    Row = i,
                                    Column = j,
                                    Type = PieceType.Queen,
                                    Color = PieceColor.White
                                };
                                break;
                            case 'k':
                                pieceBoard[i, j] = new Piece()
                                {
                                    Row = i,
                                    Column = j,
                                    Type = PieceType.King,
                                    Color = PieceColor.White
                                };
                                break;
                            case 'p':
                                pieceBoard[i, j] = new Piece()
                                {
                                    Row = i,
                                    Column = j,
                                    Type = PieceType.Pawn,
                                    Color = PieceColor.White
                                };
                                break;
                            default:
                                break;
                        }
                    }
                    else
                    {
                        switch (board[i, j][1])
                        {
                            case 'r':
                                pieceBoard[i, j] = new Piece()
                                {
                                    Row = i,
                                    Column = j,
                                    Type = PieceType.Rook,
                                    Color = PieceColor.Black
                                };
                                break;
                            case 'n':
                                pieceBoard[i, j] = new Piece()
                                {
                                    Row = i,
                                    Column = j,
                                    Type = PieceType.Knight,
                                    Color = PieceColor.Black
                                };
                                break;
                            case 'b':
                                pieceBoard[i, j] = new Piece()
                                {
                                    Row = i,
                                    Column = j,
                                    Type = PieceType.Bishop,
                                    Color = PieceColor.Black
                                };
                                break;
                            case 'q':
                                pieceBoard[i, j] = new Piece()
                                {
                                    Row = i,
                                    Column = j,
                                    Type = PieceType.Queen,
                                    Color = PieceColor.Black
                                };
                                break;
                            case 'k':
                                pieceBoard[i, j] = new Piece()
                                {
                                    Row = i,
                                    Column = j,
                                    Type = PieceType.King,
                                    Color = PieceColor.Black
                                };
                                break;
                            case 'p':
                                pieceBoard[i, j] = new Piece()
                                {
                                    Row = i,
                                    Column = j,
                                    Type = PieceType.Pawn,
                                    Color = PieceColor.Black
                                };
                                break;
                            default:
                                break;
                        }
                    }
                }

            }
            return pieceBoard;

        }
    }

}
