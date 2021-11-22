using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CC.Shared
{
    public class Tile
    {
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public bool IsOccupied { get; set; }
        public bool IsLegalNextMove { get; set; }
        public Piece Piece { get; set; }

        public Tile (int row, int column)
        {
            RowNumber = row;
            ColumnNumber = column;
        }
    }
}
