using System;
using UnityEngine;

public class Pawn : ChessPieces
{
    protected override PieceType Type => PieceType.Pawn;

    // Pawn can do a variety of moves, but for the purpose of the assignment
    // only two are shown, the basic move and the beginning game two space move
    public override void ShowMoveOptions(Vector3 position, float dimensions)
    {
        // Upwards
        Gizmos.color = Color.green;
        Gizmos.DrawCube(position + Vector3.up * dimensions, new Vector3(dimensions, dimensions, 0));

        // Beginning Upwards
        Gizmos.color = Color.red;
        Gizmos.DrawCube(position + Vector3.up * 2 * dimensions, new Vector3(dimensions, dimensions, 0));
    }
}
