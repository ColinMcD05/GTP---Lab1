using System;
using UnityEngine;

public class Rook : ChessPieces
{
    protected override void GetPieceSprite()
    {
        SpriteRenderer spriteRenderer = GetComponent<SpriteRenderer>();
        spriteRenderer.color = spriteColor;

        iconName = "Rook.png";

        Gizmos.DrawIcon(transform.position, iconName, allowScaling);
    }

    // Rook moves in a + shape
    protected override void ShowMoveOptions()
    {
        Gizmos.color = Color.green;

        // Upwards
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(transform.position + Vector3.forward * i, Vector3.one);
        }

        // Downwards
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(transform.position + Vector3.back * i, Vector3.one);
        }

        // Left
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(transform.position + Vector3.left * i, Vector3.one);
        }

        // Right
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(transform.position + Vector3.right * i, Vector3.one);
        }
    }
}
