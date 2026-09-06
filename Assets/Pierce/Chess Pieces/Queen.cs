using System;
using UnityEngine;

public class Queen : ChessPieces
{
    protected override PieceType Type => PieceType.Queen;

    protected override void GetPieceSprite()
    {
        iconName = "Queen.png";

        Gizmos.DrawIcon(transform.position, iconName, allowScaling);
    }

    // Queen moves in + shape and diaognally/
    protected override void ShowMoveOptions()
    {
        Gizmos.color = Color.green;

        // Upwards
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(transform.position + Vector3.forward * i, Vector3.one);
        }

        // Downwards
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(transform.position + Vector3.back * i, Vector3.one);
        }

        // Left
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(transform.position + Vector3.left * i, Vector3.one);
        }

        // Right
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(transform.position + Vector3.right * i, Vector3.one);
        }

        // Upwards-Left
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(transform.position + (Vector3.forward + Vector3.left) * i, Vector3.one);
        }

        // Downwards-Left
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(transform.position + (Vector3.back + Vector3.left) * i, Vector3.one);
        }

        // Upwards-Right
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(transform.position + (Vector3.forward + Vector3.right) * i, Vector3.one);
        }

        // Downwards-Right
        for (int i = 1; i <= 8; i++)
        {
            Gizmos.DrawWireCube(transform.position + (Vector3.back + Vector3.right) * i, Vector3.one);
        }
    }
}
