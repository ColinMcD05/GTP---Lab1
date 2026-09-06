using System;
using UnityEngine;

public class Bishop : ChessPieces
{
    protected override PieceType Type => PieceType.Bishop;

    protected override void GetPieceSprite()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = spriteColor;

        iconName = "Bishop.png";

        Gizmos.DrawIcon(transform.position, iconName, allowScaling);
    }

    // Bishop can only move diagonally.
    protected override void ShowMoveOptions()
    {
        Gizmos.color = Color.green;

        // Upwards-Left
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(transform.position + (Vector3.forward + Vector3.left) * i, Vector3.one);
        }

        // Downwards-Left
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(transform.position + (Vector3.back + Vector3.left) * i, Vector3.one);
        }

        // Upwards-Right
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(transform.position + (Vector3.forward + Vector3.right) * i, Vector3.one);
        }

        // Downwards-Right
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(transform.position + (Vector3.back + Vector3.right) * i, Vector3.one);
        }
    }
}
