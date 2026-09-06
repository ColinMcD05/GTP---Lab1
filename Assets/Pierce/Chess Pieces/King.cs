using System;
using UnityEngine;

public class King : ChessPieces
{
    protected override PieceType Type => PieceType.King;

    // King can move any space directly next to it
    protected override void ShowMoveOptions(Vector3 position, float dimensions)
    {
        Gizmos.color = Color.green;

        // Upper Left
        Gizmos.DrawWireCube(position + ((Vector3.forward * dimensions) + (Vector3.left * dimensions)), Vector3.one * dimensions);

        // Upwards
        Gizmos.DrawWireCube(position + Vector3.forward * dimensions, Vector3.one * dimensions);

        // Upper Right
        Gizmos.DrawWireCube(position + ((Vector3.forward * dimensions) + (Vector3.right * dimensions)), Vector3.one * dimensions);

        // Left
        Gizmos.DrawWireCube(position + Vector3.left * dimensions, Vector3.one * dimensions);

        // Right
        Gizmos.DrawWireCube(position + Vector3.right * dimensions, Vector3.one * dimensions);

        // Lower Left
        Gizmos.DrawWireCube(position + ((Vector3.back * dimensions) + (Vector3.left * dimensions)), Vector3.one * dimensions);

        // Downwards
        Gizmos.DrawWireCube(position + Vector3.back * dimensions, Vector3.one * dimensions);

        // Lower Right
        Gizmos.DrawWireCube(position + ((Vector3.back * dimensions) + (Vector3.right * dimensions)), Vector3.one * dimensions);
    }
}
