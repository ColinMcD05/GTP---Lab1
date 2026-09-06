using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(PlacedPiece), true)]
public class ChessPieceEditor : Editor
{
    // Surrounds each Chess Piece with a Handle
    private void OnSceneGUI()
    {
        PlacedPiece piece = (PlacedPiece)target;

        Vector3 position = piece.transform.position;

        Handles.color = Color.blue;

        Handles.DrawWireCube(position, new Vector3 (0.8f, 0.8f, 0));
    }
}