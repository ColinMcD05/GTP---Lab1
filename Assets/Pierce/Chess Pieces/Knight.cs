using System;
using UnityEngine;

public class Knight : ChessPieces
{
    protected override PieceType Type => PieceType.Knight;

    // Knight can only move in an L shape
    public override void ShowMoveOptions(Vector3 position, float dimensions)
    {
        Gizmos.color = Color.green;

        // Upwards-Left One
        Gizmos.DrawCube(position + ((Vector3.up) + (Vector3.left * 2) * dimensions), new Vector3(dimensions, dimensions, 0));

        // Upwards-Left Two
        Gizmos.DrawCube(position + ((Vector3.up * 2) + (Vector3.left) * dimensions), new Vector3(dimensions, dimensions, 0));

        // Downwards-Left One
        Gizmos.DrawCube(position + ((Vector3.down) + (Vector3.left * 2) * dimensions), new Vector3(dimensions, dimensions, 0));

        // Downwards-Left Two
        Gizmos.DrawCube(position + ((Vector3.down * 2) + (Vector3.left) * dimensions), new Vector3(dimensions, dimensions, 0));

        // Upwards-Right One
        Gizmos.DrawCube(position + ((Vector3.up) + (Vector3.right * 2) * dimensions), new Vector3(dimensions, dimensions, 0));

        // Upwards-Right Two
        Gizmos.DrawCube(position + ((Vector3.up * 2) + (Vector3.right) * dimensions), new Vector3(dimensions, dimensions, 0));

        // Downwards-Right One
        Gizmos.DrawCube(position + ((Vector3.down) + (Vector3.right * 2) * dimensions), new Vector3(dimensions, dimensions, 0));

        // Upwards-Right Two
        Gizmos.DrawCube(position + ((Vector3.down * 2) + (Vector3.right) * dimensions), new Vector3(dimensions, dimensions, 0));
    }
}
