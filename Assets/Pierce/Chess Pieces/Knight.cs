using System;
using UnityEngine;

public class Knight : ChessPieces
{
    protected override PieceType Type => PieceType.Knight;

    protected override void GetPieceSprite()
    {
        iconName = "Knight.png";

        Gizmos.DrawIcon(transform.position, iconName, allowScaling);
    }

    // Knight can only move in an L shape
    protected override void ShowMoveOptions()
    {
        Gizmos.color = Color.green;

        // Upwards-Left One
        Gizmos.DrawWireCube(transform.position + ((Vector3.forward) + (Vector3.left * 2)), Vector3.one);

        // Upwards-Left Two
        Gizmos.DrawWireCube(transform.position + ((Vector3.forward * 2) + (Vector3.left)), Vector3.one);

        // Downwards-Left One
        Gizmos.DrawWireCube(transform.position + ((Vector3.back) + (Vector3.left * 2)), Vector3.one);

        // Downwards-Left Two
        Gizmos.DrawWireCube(transform.position + ((Vector3.back * 2) + (Vector3.left)), Vector3.one);

        // Upwards-Right One
        Gizmos.DrawWireCube(transform.position + ((Vector3.forward) + (Vector3.right * 2)), Vector3.one);

        // Upwards-Right Two
        Gizmos.DrawWireCube(transform.position + ((Vector3.forward * 2) + (Vector3.right)), Vector3.one);

        // Downwards-Right One
        Gizmos.DrawWireCube(transform.position + ((Vector3.back) + (Vector3.right * 2)), Vector3.one);

        // Upwards-Right Two
        Gizmos.DrawWireCube(transform.position + ((Vector3.back * 2) + (Vector3.right)), Vector3.one);
    }
}
