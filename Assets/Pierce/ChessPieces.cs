using System;
using UnityEngine;

public abstract class ChessPieces : MonoBehaviour
{
    protected string iconName;
    protected bool allowScaling = true;
    
    // Enum so children of this class can categorize themselves
    protected enum PieceType
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

    // Will assign a sprite to the corresponding piece.
    protected abstract void GetPieceSprite();

    // Protected function for child classes to override
    // Shows possible movement options in the form of squares as gizmos
    protected abstract void ShowMoveOptions();

    // Only shows the move options when selected
    private void OnDrawGizmosSelected()
    {
        ShowMoveOptions();
    }
}
