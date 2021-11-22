using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CC.Shared
{
    public class Validator
    {
        public static bool[,] LegalMoves(String[,] board, int row, int column, String piece)
        {
            switch (Char.ToUpper(piece[0]))
            {
                case 'B':
                    return ValidBishopMoves(board, row, column, piece);
                case 'N':
                    return ValidBishopMoves(board, row, column, piece);
                case 'R':
                    return ValidBishopMoves(board, row, column, piece);
                case 'P':
                    return ValidBishopMoves(board, row, column, piece);
                case 'Q':
                    return ValidBishopMoves(board, row, column, piece);
                case 'K':
                    return ValidBishopMoves(board, row, column, piece);
                default:
                    return new bool[8, 8];
            }
        }

        public static bool[,] ValidBishopMoves(String[,] board, int row, int column, String piece)
        {
            int i = 1;
            bool collision = false;
            bool[,] retArr = new bool[8, 8];
            //up right
            while ((row + i < 8) && (column + i < 8) && (collision == false))
            {
                if (!(board[row + i, column + i].Equals("em")))
                {
                    collision = true;
                    if ((Char.IsUpper(piece[0]) && Char.IsLower(board[row + i, column + i][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row + i, column + i][0])))
                    {
                        retArr[row + i, column + i] = true;
                    }
                }
                else
                {
                    retArr[row + i, column + i] = true;
                }
                i++;
            }
            i = 1;
            //up left
            while ((row - i > -1) && (column + i < 8) && (collision == false))
            {
                if (!(board[row - i, column + i].Equals("em")))
                {
                    collision = true;
                    if ((Char.IsUpper(piece[0]) && Char.IsLower(board[row - i, column + i][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row - i, column + i][0])))
                    {
                        retArr[row - i, column + i] = true;
                    }
                }
                else
                {
                    retArr[row - i, column + i] = true;
                }
                i++;
            }
            i = 1;
            //down left
            while ((row - i > -1) && (column - i > -1) && (collision == false))
            {
                if (!(board[row - i, column - i].Equals("em")))
                {
                    collision = true;
                    if ((Char.IsUpper(piece[0]) && Char.IsLower(board[row - i, column - i][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row - i, column - i][0])))
                    {
                        retArr[row - i, column - i] = true;
                    }
                }
                else
                {
                    retArr[row - i, column - i] = true;
                }
                i++;
            }
            i = 1;
            //down right
            while ((row + i < 8) && (column - i > -1) && (collision == false))
            {
                if (!(board[row + i, column - i].Equals("em")))
                {
                    collision = true;
                    if ((Char.IsUpper(piece[0]) && Char.IsLower(board[row + i, column - i][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row + i, column - i][0])))
                    {
                        retArr[row + i, column - i] = true;
                    }
                }
                else
                {
                    retArr[row + i, column - i] = true;
                }
                i++;
            }
            return retArr;
        }

        public static bool[,] ValidKnightMoves(String[,] board, int row, int column, String piece)
        {
            bool[,] retArr = new bool[8, 8];
            //1
            if ((row + 2 < 8) && (column - 1 > -1)) {
                if (((row + 2 < 8) && (column - 1 > -1) && (board[row + 2, column - 1].Equals("em")))
                    || ((row + 2 < 8) && (column - 1 > -1) && ((Char.IsUpper(piece[0]) && Char.IsLower(board[row + 2, column - 1][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row + 2, column - 1][0])))))
                {
                    retArr[row + 2, column - 1] = true;
                }
            }
            //2
            if ((row + 1 < 8) && (column - 2 > -1)) {
                if (((row + 1 < 8) && (column - 2 > -1) && (board[row + 1, column - 2].Equals("em")))
                    || ((row + 1 < 8) && (column - 2 > -1) && ((Char.IsUpper(piece[0]) && Char.IsLower(board[row + 1, column - 2][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row + 1, column - 2][0])))))
                {
                    retArr[row + 1, column - 2] = true;
                }
            }
            //3
            if ((row - 1 > -1) && (column - 2 > -1)) {
                if (((row - 1 > -1) && (column - 2 > -1) && (board[row - 1, column - 2].Equals("em")))
                    || ((row - 1 > -1) && (column - 2 > -1) && ((Char.IsUpper(piece[0]) && Char.IsLower(board[row - 1, column - 2][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row - 1, column - 2][0])))))
                {
                    retArr[row - 1, column - 2] = true;
                }
            }
            //4
            if ((row - 2 > -1) && (column - 1 > -1)) {
                if (board[row - 2, column - 1].Equals("em") || ((Char.IsUpper(piece[0]) && Char.IsLower(board[row - 2, column - 1][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row - 2, column - 1][0]))))
                {
                    retArr[row - 2, column - 1] = true;
                }
            }
            //5
            if ((row - 2 > -1) && (column + 1 < 8)) {
                if (((row - 2 > -1) && (column + 1 < 8) && (board[row - 2, column + 1].Equals("em")))
                    || ((row - 2 > -1) && (column + 1 < 8) && ((Char.IsUpper(piece[0]) && Char.IsLower(board[row - 2, column + 1][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row - 2, column + 1][0])))))
                {
                    retArr[row - 2, column + 1] = true;
                }
            }
            //6
            if ((row - 1 > -1) && (column + 2 < 8)) {
                if (((row - 1 > -1) && (column + 2 < 8) && (board[row - 1, column + 2].Equals("em")))
                    || ((row - 1 > -1) && (column + 2 < 8) && ((Char.IsUpper(piece[0]) && Char.IsLower(board[row - 1, column + 2][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row - 1, column + 2][0])))))
                {
                    retArr[row - 1, column + 2] = true;
                }
            }
            //7
            if ((row + 1 < 8) && (column + 2 < 8)) {
                if (((row + 1 < 8) && (column + 2 < 8) && (board[row + 1, column + 2].Equals("em")))
                   || ((row + 1 < 8) && (column + 2 < 8) && ((Char.IsUpper(piece[0]) && Char.IsLower(board[row + 1, column + 2][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row + 1, column + 2][0])))))
                {
                    retArr[row + 1, column + 2] = true;
                }
            }
            //8
            if ((row + 2 < 8) && (column + 1 < 8)) {
                if (((row + 2 < 8) && (column + 1 < 8) && (board[row + 2, column + 1].Equals("em")))
                    || ((row + 2 < 8) && (column + 1 < 8) && ((Char.IsUpper(piece[0]) && Char.IsLower(board[row + 2, column + 1][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row + 2, column + 1][0])))))
                {
                    retArr[row + 2, column + 1] = true;
                }
            }
            return retArr;
        }

        public static bool[,] ValidRookMoves(String[,] board, int row, int column, String piece)
        {
            int i = 1;
            bool collision = false;
            bool[,] retArr = new bool[8, 8];
            // right
            while ((row + i < 8) && (collision == false))
            {
                if (!(board[row + i, column].Equals("em")))
                {
                    collision = true;
                    if ((Char.IsUpper(piece[0]) && Char.IsLower(board[row + i, column][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row + i, column][0])))
                    {
                        retArr[row + i, column] = true;
                    }
                }
                else
                {
                    retArr[row + i, column] = true;
                }
                i++;
            }
            i = 1;
            // left
            while ((row - i > -1) && (collision == false))
            {
                if (!(board[row - i, column].Equals("em")))
                {
                    collision = true;
                    if ((Char.IsUpper(piece[0]) && Char.IsLower(board[row - i, column][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row - i, column][0])))
                    {
                        retArr[row - i, column] = true;
                    }
                }
                else
                {
                    retArr[row - i, column] = true;
                }
                i++;
            }
            i = 1;
            //down
            while ((column - i > -1) && (collision == false))
            {
                if (!(board[row, column - i].Equals("em")))
                {
                    collision = true;
                    if ((Char.IsUpper(piece[0]) && Char.IsLower(board[row, column - i][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row, column - i][0])))
                    {
                        retArr[row, column - i] = true;
                    }
                }
                else
                {
                    retArr[row, column - i] = true;
                }
                i++;
            }
            i = 1;
            //up
            while ((column + i < 8) && (collision == false))
            {
                if (!(board[row, column + i].Equals("em")))
                {
                    collision = true;
                    if ((Char.IsUpper(piece[0]) && Char.IsLower(board[row, column + i][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row, column + i][0])))
                    {
                        retArr[row, column + i] = true;
                    }
                }
                else
                {
                    retArr[row, column + i] = true;
                }
                i++;
            }
            return retArr;
        }
        public static bool[,] ValidPawnMoves(String[,] board, int row, int column, String piece)
        {
            bool[,] retArr = new bool[8, 8];
            if (row == 1 && (board[row + 2, column].Equals("em")))
            {
                retArr[row + 2, column] = true;
            }
            if (((row + 1 < 8) && (board[row + 1, column].Equals("em"))))
            {
                retArr[row + 1, column] = true;
            }
            if (((row + 1 < 8) && (column + 1 < 8) && ((Char.IsUpper(piece[0]) && Char.IsLower(board[row + 1, column + 1][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row + 2, column - 1][0])))))
            {
                retArr[row + 1, column + 1] = true;
            }
            if (((row + 1 < 8) && (column - 1 > -1) && ((Char.IsUpper(piece[0]) && Char.IsLower(board[row + 1, column - 1][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row + 1, column - 1][0])))))
            {
                retArr[row + 1, column - 1] = true;
            }
            return retArr;
        }

        public static bool[,] ValidKingMoves(String[,] board, int row, int column, String piece)
        {
            bool[,] retArr = new bool[8, 8];
            //1
            if (((row + 1 < 8) && (column - 1 > -1) && (board[row + 1, column - 1].Equals("em")))
                || ((row + 1 < 8) && (column - 1 > -1) && ((Char.IsUpper(piece[0]) && Char.IsLower(board[row + 1, column - 1][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row + 1, column - 1][0])))))
            {
                retArr[row + 1, column - 1] = true;
            }
            //2
            if (((column + 1 < 8) && (board[row, column + 1].Equals("em")))
                || (column + 1 < 8) && ((Char.IsUpper(piece[0]) && Char.IsLower(board[row, column + 1][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row, column + 1][0]))))
            {
                retArr[row, column + 1] = true;
            }
            //3
            if (((column - 1 > -1) && (board[row, column - 1].Equals("em")))
                || (column - 1 > -1) && ((Char.IsUpper(piece[0]) && Char.IsLower(board[row, column - 1][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row, column - 1][0]))))
            {
                retArr[row, column - 1] = true;
            }
            //4
            if (((row - 1 > -1) && (column - 1 > -1) && (board[row - 1, column - 1].Equals("em")))
                || ((row - 1 > -1) && (column - 1 > -1) && ((Char.IsUpper(piece[0]) && Char.IsLower(board[row - 1, column - 1][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row - 1, column - 1][0])))))
            {
                retArr[row - 1, column - 1] = true;
            }
            //5
            if (((row - 1 > -1) && (board[row - 1, column].Equals("em")))
                || ((row - 1 > -1) && ((Char.IsUpper(piece[0]) && Char.IsLower(board[row - 1, column][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row - 1, column][0])))))
            {
                retArr[row - 1, column] = true;
            }
            //6
            if (((row - 1 > -1) && (column + 1 < 8) && (board[row - 1, column + 1].Equals("em")))
                || ((row - 1 > -1) && (column + 1 < 8) && ((Char.IsUpper(piece[0]) && Char.IsLower(board[row - 1, column + 1][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row - 1, column + 1][0])))))
            {
                retArr[row - 1, column + 1] = true;
            }
            //7
            if (((row + 1 < 8) && (board[row + 1, column].Equals("em")))
               || ((row + 1 < 8) && ((Char.IsUpper(piece[0]) && Char.IsLower(board[row + 1, column][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row + 1, column][0])))))
            {
                retArr[row + 1, column] = true;
            }
            //8
            if (((row + 1 < 8) && (column + 1 < 8) && (board[row + 1, column + 1].Equals("em")))
                || ((row + 1 < 8) && (column + 1 < 8) && ((Char.IsUpper(piece[0]) && Char.IsLower(board[row + 1, column + 1][0])) || (Char.IsLower(piece[0]) && Char.IsUpper(board[row + 1, column + 1][0])))))
            {
                retArr[row + 1, column + 1] = true;
            }
            return retArr;
        }

        public static bool[,] ValidQueenMoves(String[,] board, int row, int column, String piece)
        {
            bool[,] retArr = new bool[8, 8];
            bool[,] diagonalValid = ValidBishopMoves(board, row, column, piece);
            bool[,] axialValid = ValidRookMoves(board, row, column, piece);
            for (int x = 0; x < 8; x += 1)
            {
                for (int y = 0; y < 8; y += 1)
                {
                    if(diagonalValid[x, y] || axialValid[x, y])
                    {
                        retArr[x, y] = true;
                    }
                }
            }
            return retArr;
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

    }
}
