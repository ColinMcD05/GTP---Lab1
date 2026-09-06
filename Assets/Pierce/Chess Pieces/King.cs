using System;
using UnityEngine;

public class King : ChessPieces
{
    protected override PieceType Type => PieceType.King;

    protected override void GetPieceSprite()
    {
        iconName = "King.png";

        Gizmos.DrawIcon(transform.position, iconName, allowScaling);
    }

    // King can move any space directly next to it
    protected override void ShowMoveOptions()
    {
        Gizmos.color = Color.green;

        // Upper Left
        Gizmos.DrawWireCube(transform.position + ((Vector3.forward) + (Vector3.left)), Vector3.one);

        // Upwards
        Gizmos.DrawWireCube(transform.position + Vector3.forward, Vector3.one);

        // Upper Right
        Gizmos.DrawWireCube(transform.position + ((Vector3.forward) + (Vector3.right)), Vector3.one);

        // Left
        Gizmos.DrawWireCube(transform.position + Vector3.left, Vector3.one);

        // Right
        Gizmos.DrawWireCube(transform.position + Vector3.right, Vector3.one);

        // Lower Left
        Gizmos.DrawWireCube(transform.position + ((Vector3.back) + (Vector3.left)), Vector3.one);

        // Downwards
        Gizmos.DrawWireCube(transform.position + Vector3.back, Vector3.one);

        // Lower Right
        Gizmos.DrawWireCube(transform.position + ((Vector3.back) + (Vector3.right)), Vector3.one);
    }
}
