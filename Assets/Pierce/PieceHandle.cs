using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ChessPieces), true)]
public class ChessPiecesEditor : Editor
{
    // Surrounds each Chess Piece with a Handle
    private void OnSceneGUI()
    {
        ChessPieces piece = (ChessPieces)target;

        Vector3 position = piece.transform.position;

        Handles.color = Color.blue;

        Handles.DrawWireCube(position, Vector3.one);
    }
}