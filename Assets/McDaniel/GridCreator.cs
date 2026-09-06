using UnityEngine;

public class GridCreator
{

	private float dimensions;

	public GridCreator(float dimension){
		dimensions = dimension;
	}

	public void CreateBoard(ref Grid grid){
		CreateOutline();
		CreateRows(ref grid);
		CreateColumns(ref grid);
		grid.ColorSquare(dimensions);
	}

	private void CreateOutline(){
		Gizmos.color = Color.black;
		Vector3 oldVector = new Vector3(0,0,0);
		Vector3 newVector = new Vector3(0, dimensions*8, 0);
		for(int i = 0; i < 4; i++){
			Gizmos.DrawLine(oldVector, newVector);
			oldVector = newVector;
			switch (i % 4)
			{
				case 0:
					newVector = new Vector3(dimensions*8, dimensions*8, 0);
					break;
				case 1:
					newVector = new Vector3(dimensions*8, 0, 0);
					break;
				case 2:
					newVector = new Vector3(0, 0, 0);
					break;
			}
		}
	}

	private void CreateRows(ref Grid grid){
		for (int i = 0; i < 8; i++)
		{
			Gizmos.DrawLine(new Vector3(0, i * dimensions, 0), new Vector3(8 * dimensions, i * dimensions, 0));
			grid.SetRowYPosition(i, (dimensions / 2) + i);
		}
	}

	private void CreateColumns(ref Grid grid){
		for (int i = 0; i < 8; i++)
		{
            Gizmos.DrawLine(new Vector3(i * dimensions, 0, 0), new Vector3(i * dimensions, 8 * dimensions, 0));
            grid.SetColumnXPosition(i, (dimensions/2) + i);
        }
	}
}