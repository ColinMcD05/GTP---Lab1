using UnityEngine;

public class Grid
{
	//Declare variables
	private Vector3[,] grid;

	//Initialize grid
	public Grid(){
		grid = new Vector3[8,8];
	}

	//Sets the x position for all rows in column
	public void SetColumnXPosition(int column, float newPosition){
		for(int i = 0; i < 8; i++){
			grid[column, i].x = newPosition;
		}
	}

	//Sets the y position for all columns in row
	public void SetRowYPosition(int row, float newPosition){
		for(int i = 0; i < 8; i++){
			grid[i, row].y = newPosition;
		}
    }

	//Adds and colors in the sqaures of the grid
	public void ColorSquare(float dimensions)
	{
		for(int i = 0; i < 8; i++)
		{
			for(int j = 0; j < 8; j++)
			{
				if((i+j)%2 == 1)
				{
					Gizmos.color = Color.white;
				}
				else
				{
					Gizmos.color = Color.black;
				}
				Gizmos.DrawCube(grid[i,j], new Vector3(dimensions, dimensions, 0));
			}
		}
	}

	public Vector3 GetPosition(Vector2Int position)
	{
		return grid[position.x, position.y];
	}
}
