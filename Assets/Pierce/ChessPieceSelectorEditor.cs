using UnityEditor;
using UnityEngine;

[CustomEditor(typeof(ChessPieceSelector))]
public class ChessPieceSelectorEditor : Editor
{
    // Idk if making the the custom Inspector is completely necessary
    public override void OnInspectorGUI()
    {
        // Creates a custom Inspector so we can create our own Piece type dropdown
        ChessPieceSelector selector = (ChessPieceSelector)target;

        ChessPieceSelector.PieceType newType = (ChessPieceSelector.PieceType)EditorGUILayout.EnumPopup("Piece Type", selector.Type);

        // Checks if a new chess piece type has been chosen
        if (newType != selector.Type)
        {
            Undo.RecordObject(selector, "Change Chess Piece");

            SwapPiece(selector.gameObject, newType);

            EditorUtility.SetDirty(selector);
        }
    }

    private void SwapPiece(GameObject pieceObject, ChessPieceSelector.PieceType type)
    {
        // Removes the chess piece that was switched off of
        ChessPieces existingPiece = pieceObject.GetComponent<ChessPieces>();

        if (existingPiece != null)
        {
            DestroyImmediate(existingPiece);
        }

        // Switch to change the piece to the one selected
        switch (type)
        {
            case ChessPieceSelector.PieceType.Pawn:
                pieceObject.AddComponent<Pawn>();
                break;

            case ChessPieceSelector.PieceType.Rook:
                pieceObject.AddComponent<Rook>();
                break;

            case ChessPieceSelector.PieceType.Knight:
                pieceObject.AddComponent<Knight>();
                break;

            case ChessPieceSelector.PieceType.Bishop:
                pieceObject.AddComponent<Bishop>();
                break;

            case ChessPieceSelector.PieceType.Queen:
                pieceObject.AddComponent<Queen>();
                break;

            case ChessPieceSelector.PieceType.King:
                pieceObject.AddComponent<King>();
                break;
        }
    }
}