using System;
using UnityEngine;

public class Pawn : ChessPieces
{
    protected override PieceType Type => PieceType.Pawn;

    // Pawn can do a variety of moves, but for the purpose of the assignment
    // only two are shown, the basic move and the beginning game two space move
    protected override void ShowMoveOptions(Vector3 position, float dimensions)
    {
        // Upwards
        Gizmos.color = Color.green;
        Gizmos.DrawWireCube(position + Vector3.forward * dimensions, Vector3.one * dimensions);

        // Beginning Upwards
        Gizmos.color = Color.red;
        Gizmos.DrawWireCube(position + Vector3.forward * 2 * dimensions, Vector3.one * dimensions);
    }
}
