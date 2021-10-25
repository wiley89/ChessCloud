using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC.Shared
{
    public class Validator
    {
        public bool isMoveLegal(Piece piece, Piece[,] pieceBoard, string fen, int startRow, int StartColumn, int endRow, int endStartColumn) 
        {
            switch(piece.Type)
            {
                case PieceType.Bishop:
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
    }
}
