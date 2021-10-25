using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC.Shared
{
    public class Validator
    {
        public bool isMoveLegal(Piece piece, Piece[,] pieceBoard, string fen, int startRow, int startColumn, int endRow, int endColumn) 
        {
            if (startRow >= 0 && startRow < 8 && startColumn >= 0 && startColumn < 8 && endRow >= 0 && endRow < 8 && endColumn >= 0 && endColumn < 8)
            {
                switch (piece.Type)
                {
                    case PieceType.Bishop:
                        if (isValidBishopMove(startRow, startColumn, endRow, endColumn) && (pieceBoard[endRow, endColumn] == null || pieceBoard[endRow, endColumn].Color != pieceBoard[startRow, startColumn].Color))
                        {
                            return true;
                        }
                        break;
                    case PieceType.Knight:
                        if (isValidKnightMove(startRow, startColumn, endRow, endColumn) && (pieceBoard[endRow, endColumn] == null || pieceBoard[endRow, endColumn].Color != pieceBoard[startRow, startColumn].Color))
                        {
                            return true;
                        }
                        break;
                    case PieceType.Rook:
                        if (isValidRookMove(startRow, startColumn, endRow, endColumn) && (pieceBoard[endRow, endColumn] == null || pieceBoard[endRow, endColumn].Color != pieceBoard[startRow, startColumn].Color))
                        {
                            return true;
                        }
                        break;
                    case PieceType.Pawn:
                        if ((isValidPawnMove(startRow, startColumn, endRow, endColumn) && pieceBoard[endRow, endColumn] == null)) //|| (isValidPawnEatingMove(startRow, startColumn, endRow, endColumn) && pieceBoard[endRow, endColumn].Color != pieceBoard[startRow, startColumn].Color))
                        {
                            return true;
                        }
                        break;
                    case PieceType.Queen:
                        if (isValidQueenMove(startRow, startColumn, endRow, endColumn) && (pieceBoard[endRow, endColumn] == null || pieceBoard[endRow, endColumn].Color != pieceBoard[startRow, startColumn].Color))
                        {
                            return true;
                        }
                        break;
                    case PieceType.King:
                        if (isValidKingMove(startRow, startColumn, endRow, endColumn) && (pieceBoard[endRow, endColumn] == null || pieceBoard[endRow, endColumn].Color != pieceBoard[startRow, startColumn].Color))
                        {
                            return true;
                        }
                        break;
                    default:
                        break;
                }
            }
            return false;
        }
        /*
        public bool isCheckMate(String fen) 
        {
            return false;
        }
        public bool isStaleMate(String fen)
        {
            return false;
        }*/



        /*
         * Theoretical Valid placements for each piece
         */
        public bool isValidBishopMove(int startRow, int startColumn, int endRow, int endColumn)
        {
            if (Math.Abs(startRow - endRow) == Math.Abs(startColumn - endColumn))
            {
                return true;
            }
            return false;
        }

        public bool isValidKnightMove(int startRow, int startColumn, int endRow, int endColumn)
        {
            if ((Math.Abs(startRow - endRow) == 1 && Math.Abs(startColumn - endColumn) == 2) || (Math.Abs(startRow - endRow) == 2 && Math.Abs(startColumn - endColumn) == 1))
            {
                return true;
            }
            return false;
        }

        public bool isValidRookMove(int startRow, int startColumn, int endRow, int endColumn)
        {
            if (Math.Abs(startRow - endRow) == 0 || Math.Abs(startColumn - endColumn) == 0)
            {
                return true;
            }
            return false;
        }
        public bool isValidPawnMove(int startRow, int startColumn, int endRow, int endColumn)
        {
            //first move - 2 steps
            if (Math.Abs(startRow - endRow) == 1 && Math.Abs(startColumn - endColumn) == 0)
            {
                return true;
            }
            return false;
        }
        public bool isValidPawnEatingMove(int startRow, int startColumn, int endRow, int endColumn)
        {
            if (Math.Abs(startRow - endRow) == 1 && Math.Abs(startColumn - endColumn) == 1)
            {
                return true;
            }
            return false;
        }

        public bool isValidKingMove(int startRow, int startColumn, int endRow, int endColumn)
        {
            if (Math.Abs(startRow - endRow) == 1 && Math.Abs(startColumn - endColumn) == 1)
            {
                return true;
            }
            return false;
        }

        public bool isValidQueenMove(int startRow, int startColumn, int endRow, int endColumn)
        {
            if (isValidBishopMove(startRow, startColumn, endRow, endColumn) || isValidRookMove(startRow, startColumn, endRow, endColumn))
            {
                return true;
            }
            return false;
        }

    }
}
