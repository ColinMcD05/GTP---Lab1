using System;
using UnityEngine;

public class Pawn : ChessPieces
{
    protected override PieceType Type => PieceType.Pawn;

    protected override void GetPieceSprite()
    {
        iconName = "Pawn.png";

        Gizmos.DrawIcon(transform.position, iconName, allowScaling);
    }

    // Pawn can do a variety of moves, but for the purpose of the assignment
    // only two are shown, the basic move and the beginning game two space move
    protected override void ShowMoveOptions()
    {
        // Upwards
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(transform.position + Vector3.forward, Vector3.one);

        // Beginning Upwards
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(transform.position + Vector3.forward * 2, Vector3.one);
    }
}
