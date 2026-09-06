using System;
using UnityEngine;

public class Bishop : ChessPieces
{
    protected override PieceType Type => PieceType.Bishop;

    // Bishop can only move diagonally.
    protected override void ShowMoveOptions(Vector3 position, float dimensions)
    {
        Gizmos.color = Color.green;

        // Upwards-Left
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(position + (Vector3.forward + Vector3.left) * i * dimensions, Vector3.one * dimensions);
        }

        // Downwards-Left
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(position + (Vector3.back + Vector3.left) * i * dimensions, Vector3.one * dimensions);
        }

        // Upwards-Right
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(position + (Vector3.forward + Vector3.right) * i, Vector3.one * dimensions);
        }

        // Downwards-Right
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(position + (Vector3.back + Vector3.right) * i * dimensions, Vector3.one * dimensions);
        }
    }
}
