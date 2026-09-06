using UnityEngine;

public class ChessPieceSelector : MonoBehaviour
{
   // Enum so that the Piece Type can be changed by the user in interface/
    public enum PieceType
    {
        Pawn,
        Rook,
        Knight,
        Bishop,
        Queen,
        King
    }

    [SerializeField]
    private PieceType pieceType;

    public PieceType Type => pieceType;
}