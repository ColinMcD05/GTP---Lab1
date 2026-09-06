using System;
using UnityEngine;

public class Knight : ChessPieces
{
    protected override PieceType Type => PieceType.Knight;

    // Knight can only move in an L shape
    protected override void ShowMoveOptions(Vector3 position, float dimensions)
    {
        Gizmos.color = Color.green;

        // Upwards-Left One
        Gizmos.DrawWireCube(position + ((Vector3.forward) + (Vector3.left * 2) * dimensions), Vector3.one * dimensions);

        // Upwards-Left Two
        Gizmos.DrawWireCube(position + ((Vector3.forward * 2) + (Vector3.left) * dimensions), Vector3.one * dimensions);

        // Downwards-Left One
        Gizmos.DrawWireCube(position + ((Vector3.back) + (Vector3.left * 2) * dimensions), Vector3.one * dimensions);

        // Downwards-Left Two
        Gizmos.DrawWireCube(position + ((Vector3.back * 2) + (Vector3.left) * dimensions), Vector3.one * dimensions);

        // Upwards-Right One
        Gizmos.DrawWireCube(position + ((Vector3.forward) + (Vector3.right * 2) * dimensions), Vector3.one * dimensions);

        // Upwards-Right Two
        Gizmos.DrawWireCube(position + ((Vector3.forward * 2) + (Vector3.right) * dimensions), Vector3.one * dimensions);

        // Downwards-Right One
        Gizmos.DrawWireCube(position + ((Vector3.back) + (Vector3.right * 2) * dimensions), Vector3.one * dimensions);

        // Upwards-Right Two
        Gizmos.DrawWireCube(position + ((Vector3.back * 2) + (Vector3.right) * dimensions), Vector3.one * dimensions);
    }
}
