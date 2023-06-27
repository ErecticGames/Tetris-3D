using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayGrid : MonoBehaviour
{
	#region Variables
	// declare grid planes
	 public GameObject BottomPlane;
	 public GameObject faceA, faceB, faceC, faceD;

	[Header("Grid Size")]
	public int Xsize;
	public int Ysize;
	public int Zsize;
	public float GridSpace;

	[Header("Grid Attributes")]
	public Vector3 gridOrigin;
	public Vector3 gridWallA;
	public Vector3 gridWallB;
	public Vector3 gridWallC;
	public Vector3 gridWallD;
	public Transform floorPerent;
	public Transform[] wallPerent;
	#endregion
	// Start is called before the first frame update
	void Start()
	{
		for (int a = 0; a < Xsize; a++)
		{
			
			for (int b = 0; b < Zsize; b++)
			{
				Vector3 spawnPosition = new Vector3(a * GridSpace, 0 , b * GridSpace) + gridOrigin;
				Floor(spawnPosition, Quaternion.Euler(90, 0, 0));
			}			
		}//Floor
		for (int c = 0; c < Zsize; c++)
		{
			for (int d = 0; d < Ysize; d++)
			{
				Vector3 spawnPositionW = new Vector3(c * GridSpace, d * GridSpace, 0) + gridWallA;
				Face01(spawnPositionW, Quaternion.identity);
			}
		}//WallA
		for (int c = 0; c < Zsize; c++)
		{
			for (int d = 0; d < Ysize; d++)
			{
				Vector3 spawnPositionW = new Vector3(0, d * GridSpace, c * GridSpace) + gridWallB;
				Face02(spawnPositionW, Quaternion.Euler(0, 90, 0));
			}
		}//WallB
		for (int c = 0; c < Zsize; c++)
		{
			for (int d = 0; d < Ysize; d++)
			{
				Vector3 spawnPositionW = new Vector3(0, d * GridSpace, c * GridSpace) + gridWallC;
				Face03(spawnPositionW, Quaternion.Euler(0, -90, 0));
			}
		}//WallC
		for (int c = 0; c < Zsize; c++)
		{
			for (int d = 0; d < Ysize; d++)
			{
				Vector3 spawnPositionW = new Vector3(c * GridSpace, d * GridSpace, 0) + gridWallD;
				Face04(spawnPositionW, Quaternion.Euler(0, 180, 0));
			}
		}//WallD
	}//Grid Spawner Loops
	void Floor(Vector3 positionToSpawn, Quaternion rotationToSpawn)
    {
		GameObject floor = Instantiate(BottomPlane, positionToSpawn , rotationToSpawn , floorPerent);

	}//Grid Spawner floor
	void Face01(Vector3 positionToSpawn, Quaternion rotationToSpawn)
	{
		GameObject wall = Instantiate(faceA, positionToSpawn, rotationToSpawn, wallPerent[0]);

	}//Grid Spawner wall A
	void Face02(Vector3 positionToSpawn, Quaternion rotationToSpawn)
	{
		GameObject wall = Instantiate(faceB, positionToSpawn, rotationToSpawn, wallPerent[1]);

	}//Grid Spawner wall B
	void Face03(Vector3 positionToSpawn, Quaternion rotationToSpawn)
	{
		GameObject wall = Instantiate(faceC, positionToSpawn, rotationToSpawn, wallPerent[2]);

	}//Grid Spawner wall C
	void Face04(Vector3 positionToSpawn, Quaternion rotationToSpawn)
	{
		GameObject wall = Instantiate(faceD, positionToSpawn, rotationToSpawn, wallPerent[3]);

	}//Grid Spawner wall D
}