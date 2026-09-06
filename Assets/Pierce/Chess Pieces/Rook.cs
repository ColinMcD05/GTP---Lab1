using System;
using UnityEngine;

public class Rook : ChessPieces
{
    protected override PieceType Type => PieceType.Rook;

    // Rook moves in a + shape
    public override void ShowMoveOptions(Vector3 position, float dimensions)
    {
        Gizmos.color = Color.green;

        // Upwards
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawCube(position + Vector3.up * i * dimensions, new Vector3(dimensions, dimensions, 0));
        }

        // Downwards
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawCube(position + Vector3.down * i * dimensions, new Vector3(dimensions, dimensions, 0));
        }

        // Left
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawCube(position + Vector3.left * i * dimensions, new Vector3(dimensions, dimensions, 0));
        }

        // Right
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawCube(position + Vector3.right * i * dimensions, new Vector3(dimensions, dimensions, 0));
        }
    }
}
