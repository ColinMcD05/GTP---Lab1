using System;
using UnityEngine;

public class King : ChessPieces
{
    protected override PieceType Type => PieceType.King;

    // King can move any space directly next to it
    public override void ShowMoveOptions(Vector3 position, float dimensions)
    {
        Gizmos.color = Color.green;

        // Upper Left
        Gizmos.DrawCube(position + ((Vector3.up * dimensions) + (Vector3.left * dimensions)), new Vector3(dimensions, dimensions, 0));

        // Upwards
        Gizmos.DrawCube(position + Vector3.up * dimensions, new Vector3(dimensions, dimensions, 0));

        // Upper Right
        Gizmos.DrawCube(position + ((Vector3.up * dimensions) + (Vector3.right * dimensions)), new Vector3(dimensions, dimensions, 0));

        // Left
        Gizmos.DrawCube(position + Vector3.left * dimensions, new Vector3(dimensions, dimensions, 0));

        // Right
        Gizmos.DrawCube(position + Vector3.right * dimensions, new Vector3(dimensions, dimensions, 0));

        // Lower Left
        Gizmos.DrawCube(position + ((Vector3.down * dimensions) + (Vector3.left * dimensions)), new Vector3(dimensions, dimensions, 0));

        // Downwards
        Gizmos.DrawCube(position + Vector3.down * dimensions, new Vector3(dimensions, dimensions, 0));

        // Lower Right
        Gizmos.DrawCube(position + ((Vector3.down * dimensions) + (Vector3.right * dimensions)), new Vector3(dimensions, dimensions, 0));
    }
}
