using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ChessCloud.Data
{
    public class Validator
    {
        public bool isMoveLegal(Piece current, String fen, int startRow, int StartColumn, int endRow, int endStartColumn) 
        {
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
