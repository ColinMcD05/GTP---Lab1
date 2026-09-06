using Unity.VisualScripting;
using UnityEngine;

public class PlacedPiece : MonoBehaviour
{
    //Enums
    private enum ColorTints
    {
        White,
        Red,
        Yellow,
        Green,
        Blue,
        Black
    }

    //Variables
    [SerializeField] private Vector2Int gridPlacement;
    [SerializeField] private ChessPieces.PieceType chosenType;
    [SerializeField] private ColorTints chosenColor;
    private BoardManager boardManager;
    private ChessPieces piece;
    private Color tint;

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

        tint = chosenColor switch
        {
            ColorTints.Red => Color.red,
            ColorTints.Yellow => Color.yellow,
            ColorTints.Blue => Color.blue,
            ColorTints.Green => Color.green,
            ColorTints.White => Color.white,
            ColorTints.Black => Color.black
        };

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
        piece.DrawImage(transform.position, tint);
    }

    private void OnDrawGizmosSelected()
    {
        piece.ShowMoveOptions(transform.position, boardManager.GetDimensions());
    }
#endif

    public ChessPieces GetPiece()
    {
        return piece;
    }
}