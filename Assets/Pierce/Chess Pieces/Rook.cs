using System;
using UnityEngine;

public class Rook : ChessPieces
{
    protected override PieceType Type => PieceType.Rook;

    // Rook moves in a + shape
    protected override void ShowMoveOptions(Vector3 position, float dimensions)
    {
        Gizmos.color = Color.green;

        // Upwards
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(position + Vector3.forward * i * dimensions, Vector3.one * dimensions);
        }

        // Downwards
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(position + Vector3.back * i * dimensions, Vector3.one * dimensions);
        }

        // Left
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(position + Vector3.left * i * dimensions, Vector3.one * dimensions);
        }

        // Right
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(position + Vector3.right * i * dimensions, Vector3.one * dimensions);
        }
    }
}
