using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC.Shared
{
    public class ChessGame
    {
        //intitial placement

        public string FEN { get; set; }

        private static string initialFen = "rnbqkbnr/pppppppp/8/8/8/8/PPPPPPPP/RNBQKBNR w KQkq - 0 1";

        public string generateFen(string[,] board)
        {
            StringBuilder builder = new StringBuilder();
            int emptySpaces = 0;
            for (int i = 0; i < 8; i++)
            {
                for (int j = 0; j < 8; j++)
                {
                    if (board[i, j] == "em")
                    {
                        emptySpaces++;
                    } else
                    {
                        if (emptySpaces > 0)
                        {
                            builder.Append(emptySpaces);
                            emptySpaces = 0;
                        }
                        builder.Append(board[i, j]);
                    }
                }
                if (emptySpaces > 0)
                {
                    builder.Append(emptySpaces);
                    emptySpaces = 0;
                }

                if (i != 8)
                    builder.Append("/");
            }
            return builder.ToString();
        }

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
                
                foreach (char c in currentRow)
                {
                    if (column < 8)
                    {
                        if (Char.IsDigit(c))
                        {
                            for (int j = c - '0'; j > 0; j--)
                            {
                                board[i, column] = "em";
                                column++;
                            }
                        }
                        else
                        {
                            board[i, column] = "" + c;
                            column++;
                        }
                    }
                }
            }
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
                    else if (Char.IsUpper(board[i, j][0]))
                    {
                        switch (Char.ToLower(board[i, j][0]))
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
                        switch (board[i, j][0])
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
