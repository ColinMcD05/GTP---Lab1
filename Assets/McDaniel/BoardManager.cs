using UnityEngine;

public class BoardManager : MonoBehaviour
{
	private Grid grid;
	[SerializeField] private int dimensionOfSqaures = 1;
	private GridCreator gridCreator;

	public BoardManager(){
		gridCreator = new GridCreator(dimensionOfSqaures);
	}

	private void Start(){
		grid = new Grid();
	}

	#if UNITY_EDITOR
	private void OnDrawGizmos(){
		gridCreator.CreateBoard(ref grid);
	}
	#endif
	
	public int GetDimensions(){
		return dimensionOfSqaures;
	}
}
