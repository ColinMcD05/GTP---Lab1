using System;
using UnityEngine;

public abstract class ChessPieces : MonoBehaviour
{
    protected string iconName;
    protected bool allowScaling = true;
    [SerializeField] protected Color spriteColor = Color.white;

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
