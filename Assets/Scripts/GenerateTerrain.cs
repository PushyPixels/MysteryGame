using UnityEngine;
using System.Collections;

public class GenerateTerrain : MonoBehaviour
{
	public float perlinFactor = 100.0f;
	private Terrain terrain;
		
	[ContextMenu("GeneratePerlinTerrain")]
	void GeneratePerlinTerrain()
	{
		terrain = GetComponent<Terrain>();

		float[,] heights = new float[terrain.terrainData.heightmapWidth,terrain.terrainData.heightmapHeight];

		float xOffset = Random.Range(0.0f,1000.0f);
		float yOffset = Random.Range(0.0f,1000.0f);

		for(int x = 0; x < terrain.terrainData.heightmapWidth; x++)
		{
			for(int y = 0; y < terrain.terrainData.heightmapHeight; y++)
			{
				heights[x,y] = Mathf.PerlinNoise(x/perlinFactor + xOffset,y/perlinFactor + yOffset);
			}
		}


		terrain.terrainData.SetHeights(0,0,heights);
	}
}
