using UnityEngine;

public class BoardManager : MonoBehaviour
{
	private Grid grid;
	[SerializeField] private float dimensionOfSqaures = 1;
	private GridCreator gridCreator;

	public BoardManager(){
		gridCreator = new GridCreator(dimensionOfSqaures);
        grid = new Grid();
    }

	#if UNITY_EDITOR
	private void OnDrawGizmos(){
		gridCreator.CreateBoard(ref grid);
	}
	#endif
	
	public float GetDimensions(){
		return dimensionOfSqaures;
	}
}
