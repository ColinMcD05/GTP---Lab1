using Unity.VisualScripting;
using UnityEngine;

public class PlacedPiece : MonoBehaviour
{
    //Variables
    [SerializeField] private Vector2Int gridPlacement;
    [SerializeField] private ChessPieces.PieceType chosenType;
    private ChessPieces.PieceType oldType;
    private BoardManager boardManager;
    private ChessPieces piece;

    public PlacedPiece()
    {
        oldType = chosenType;
        piece = ChangePiece(oldType);
    }

    //Changes Piece Reference
    private ChessPieces ChangePiece(ChessPieces.PieceType type)
    {
        switch (oldType)
        {
            case ChessPieces.PieceType.Pawn:
                return new Pawn();
            case ChessPieces.PieceType.Rook:
                return new Rook();
            case ChessPieces.PieceType.Knight:
                return new Knight();
            case ChessPieces.PieceType.Bishop:
                return new Bishop();
            case ChessPieces.PieceType.Queen:
                return new Queen();
            case ChessPieces.PieceType.King:
                return new King();
        }
        return null;
    }

#if UNITY_EDITOR
    private void OnValidate()
    {
        //Assign boardManager
        if (boardManager == null)
        {
            boardManager = GameObject.Find("Board").GetComponent<BoardManager>();
        }

        //Change piece if swapped
        if (oldType != chosenType)
        {
            oldType = chosenType;
            piece = ChangePiece(chosenType);
        }
    }

    void OnDrawGizmos()
    {

    }
#endif
}
