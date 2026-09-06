using Unity.VisualScripting;
using UnityEngine;

public class PlacedPiece : MonoBehaviour
{
    //Variables
    [SerializeField] private Vector2Int gridPlacement;
    [SerializeField] private ChessPieces.PieceType chosenType;
    private BoardManager boardManager;
    private ChessPieces piece;

    public PlacedPiece()
    {
        piece = ChangePiece(chosenType);
    }

    //Changes Piece Reference
    private ChessPieces ChangePiece(ChessPieces.PieceType type)
    {
        switch (type)
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
    void OnDrawGizmos()
    {
        //Handle outof bounds errors
        if (gridPlacement.x > 7)
        {
            gridPlacement.x = 7;
        }
        else if (gridPlacement.y < 0)
        {
            gridPlacement.x = 0;
        }
        if (gridPlacement.y > 7)
        {
            gridPlacement.y = 7;
        }
        else if (gridPlacement.y < 0)
        {
            gridPlacement.y = 0;
        }

        //Assign boardManager
        if (boardManager == null)
        {
            boardManager = GameObject.Find("Board").GetComponent<BoardManager>();
        }

        //Change piece if swapped
        if (piece.GetTypeVar() != chosenType)
        {
            piece = ChangePiece(chosenType);
        }

        transform.position = boardManager.GetGrid().GetPosition(gridPlacement);
        piece.DrawImage(transform.position);
    }

    private void OnDrawGizmosSelected()
    {
        piece.ShowMoveOptions(transform.position, boardManager.GetDimensions());
    }
#endif
}
