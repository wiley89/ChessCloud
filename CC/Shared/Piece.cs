using System;

/// <summary>
/// Summary description for Class1
/// </summary>
namespace CC.Shared
{
	public class Piece
	{
		public Piece()
		{

		}

		public int Row { get; set; }
		public int Column { get; set; }
		public PieceType Type { get; set; }
		public PieceColor Color { get; set; }

	}

	public enum PieceType
    {
		Pawn,
		Bishop,
		Knight,
		Rook,
		Queen,
		King
	}

	public enum PieceColor
    {
		Black,
		White
    }

	
}


