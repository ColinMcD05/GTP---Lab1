using UnityEngine;

public class Grid
{
	private Vector3[,] grid;

	public Grid(){
		grid = new Vector3[8,8];
	}

	public void SetColumnXPosition(int column, float newPosition){
		for(int i = 0; i < 8; i++){
			grid[column, i].x = newPosition;
		}
	}

	public void SetRowYPosition(int row, float newPosition){
		for(int i = 0; i < 8; i++){
			grid[i, row].y = newPosition;
		}
    }

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
}
