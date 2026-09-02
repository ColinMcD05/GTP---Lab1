using UnityEngine;

public class Grid
{
	private Vector3[,] grid;

	public Grid(){
		grid = new Vector3[8,8];
	}

	public void SetRowXPosition(int row, int newPosition){
		for(int i = 0; i < 8; i++){
			grid[row, i].x = newPosition;
		}
	}

	public void SetColumnYPosition(int column, int newPosition){
		for(int i = 0; i < 8; i++){
			grid[i, column].y = newPosition;
		}
	}
}
