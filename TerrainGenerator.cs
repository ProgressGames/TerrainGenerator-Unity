using UnityEngine;

public class TerrainGenerator : MonoBehaviour
{
    public int width = 10;
    public int depth = 10;
    public int height = 5;
    public GameObject cubePrefab;
    public Material greenMaterial;

    void Start()
    {
        GenerateTerrain();
    }

    void GenerateTerrain()
    {
        for (int x = 0; x < width; x++)
        {
            for (int z = 0; z < depth; z++)
            {
                int y = Mathf.FloorToInt(Mathf.PerlinNoise(x * 0.3f, z * 0.3f) * height);
                Vector3 position = new Vector3(x, y, z);
                GameObject cube = Instantiate(cubePrefab, position, Quaternion.identity);
                cube.GetComponent<Renderer>().material = greenMaterial;
            }
        }
    }
}
