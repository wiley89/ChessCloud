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
            switch(piece.Type)
            {
                case PieceType.Bishop:
                    //if
                    break;
                case PieceType.Knight:
                    break;
                case PieceType.Rook:
                    break;
                case PieceType.Pawn:
                    break;
                case PieceType.Queen:
                    break;
                case PieceType.King:
                    break;
                default:
                    break;
            }
            return false;
        }
        public bool isCheckMate(String fen) 
        {
            return false;
        }
        public bool isStaleMate(String fen)
        {
            return false;
        }


        private bool isValidBishopMove(int startRow, int startColumn, int endRow, int endColumn)
        {
            if (Math.Abs(startRow - endRow) == Math.Abs(startColumn - endColumn))
            {
                return true;
            }
            return false;
        }

        private bool isValidKnightMove(int startRow, int startColumn, int endRow, int endColumn)
        {
            if ((Math.Abs(startRow - endRow) == 1 && Math.Abs(startColumn - endColumn) == 2) || (Math.Abs(startRow - endRow) == 2 && Math.Abs(startColumn - endColumn) == 1))
            {
                return true;
            }
            return false;
        }

        private bool isValidRookMove(int startRow, int startColumn, int endRow, int endColumn)
        {
            if (Math.Abs(startRow - endRow) == 0 || Math.Abs(startColumn - endColumn) == 0)
            {
                return true;
            }
            return false;
        }
        private bool isValidPawnMove(int startRow, int startColumn, int endRow, int endColumn)
        {
            //first move - 2 steps
            if (Math.Abs(startRow - endRow) == 1 && Math.Abs(startColumn - endColumn) == 0)
            {
                return true;
            }
            return false;
        }
        private bool isValidPawnEatingMove(int startRow, int startColumn, int endRow, int endColumn)
        {
            if (Math.Abs(startRow - endRow) == 1 && Math.Abs(startColumn - endColumn) == 1)
            {
                return true;
            }
            return false;
        }

        private bool isValidKingMove(int startRow, int startColumn, int endRow, int endColumn)
        {
            if (Math.Abs(startRow - endRow) == 1 && Math.Abs(startColumn - endColumn) == 1)
            {
                return true;
            }
            return false;
        }

    }
}
