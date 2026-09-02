using UnityEngine;

public class BoardManager : MonoBehaviour
{
	private Vector3 [,] grid;
	[SerializeField] private int dimensionOfSqaures;
	private GridCreator gridCreator;

	private void Start(){
		gridCreator = new GridCreator(dimensionOfSqaures);
		grid = new Vector3[8,8];
	}

	#if UNITY_EDITOR

	#endif
}
