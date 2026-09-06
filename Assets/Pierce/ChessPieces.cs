using System;
using UnityEngine;

public abstract class ChessPieces
{
    [SerializeField] protected Color spriteColor = Color.white;
    
    // Enum so children of this class can categorize themselves
    public enum PieceType
    {
        Pawn,
        Rook,
        Knight,
        Bishop,
        Queen,
        King
    }

    // Allows user to change color tint in Unity interface


    // Each child of ChessPieces will provide a PieceType Type so that they can override GetPieceType
    // This will allow the sprites to be assigned to the correct pieces.
    [SerializeField] protected abstract PieceType Type { get; }

    public PieceType GetTypeVar()
    {
        return Type;
    }

    // Will assign a sprite to the corresponding piece.
    public void DrawImage(Vector3 position)
    {
        Gizmos.DrawIcon(position, Type.ToString(), true);
    }

    // Protected function for child classes to override
    // Shows possible movement options in the form of squares as gizmos
    public abstract void ShowMoveOptions(Vector3 position, float dimensions);
}
