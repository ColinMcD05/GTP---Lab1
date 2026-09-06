using UnityEngine;

public class BoardManager : MonoBehaviour
{
	//Declare Variables
	private Grid grid;
	private float dimensionOfSqaures = 1;
	private GridCreator gridCreator;

	// Initialize GridCreator and Grid
	public BoardManager(){
		gridCreator = new GridCreator(dimensionOfSqaures);
        grid = new Grid();
    }

	#if UNITY_EDITOR
	private void OnDrawGizmos(){
		//Draw board
		gridCreator.CreateBoard(ref grid);
	}
	#endif
	
	//Getter Functions
	public float GetDimensions(){
		return dimensionOfSqaures;
	}

	public Grid GetGrid()
	{
		return grid;
	}
}
