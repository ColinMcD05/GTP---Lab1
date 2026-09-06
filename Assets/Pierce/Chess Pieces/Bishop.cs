using System;
using UnityEngine;

public class Bishop : ChessPieces
{
    protected override PieceType Type => PieceType.Bishop;

    // Bishop can only move diagonally.
    public override void ShowMoveOptions(Vector3 position, float dimensions)
    {
        Gizmos.color = Color.green;

        // Upwards-Left
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawCube(position + (Vector3.up + Vector3.left) * i * dimensions, new Vector3(dimensions, dimensions, 0));
        }

        // Downwards-Left
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawCube(position + (Vector3.down + Vector3.left) * i * dimensions, new Vector3(dimensions, dimensions, 0));
        }

        // Upwards-Right
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawCube(position + (Vector3.up + Vector3.right) * i, new Vector3(dimensions, dimensions, 0));
        }

        // Downwards-Right
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawCube(position + (Vector3.down + Vector3.right) * i * dimensions, new Vector3(dimensions, dimensions, 0));
        }
    }
}
