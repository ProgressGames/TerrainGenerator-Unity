RU 🪆:

Шаги:
Создать новый проект в Unity.
Создать пустой GameObject в сцене и прикрепить к нему скрипт для генерации террейна.
Создать материал для кубов зелёного цвета.
Написать скрипт для генерации кубов.
Шаг 1: Создать новый проект в Unity
Откройте Unity и создайте новый 3D проект.

Шаг 2: Создать пустой GameObject
В иерархии сцены нажмите правой кнопкой мыши и выберите Create Empty, затем переименуйте его в TerrainGenerator.

Шаг 3: Создать материал
В папке Assets нажмите правой кнопкой мыши и выберите Create -> Material.
Переименуйте материал в GreenMaterial.
В инспекторе измените его цвет на зелёный.
Шаг 4: Написать скрипт
В папке Assets создайте папку Scripts.
Внутри папки Scripts нажмите правой кнопкой мыши и выберите Create -> C# Script. Назовите его TerrainGenerator.
Откройте скрипт и замените его содержимое следующим кодом:
csharp
Копировать код
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
Вернитесь в Unity и создайте префаб куба:

В иерархии сцены нажмите правой кнопкой мыши и выберите 3D Object -> Cube.
Перетащите созданный куб в папку Assets для создания префаба.
Удалите куб из иерархии сцены.
Перетащите созданный префаб куба и материал GreenMaterial на соответствующие поля в инспекторе для TerrainGenerator.


============================================================================
============================================================================
============================================================================


ENG 💑:

Steps:
Create a new project in Unity.
Create an empty GameObject in the scene and attach a script to it to generate a terrain.
Create a material for green cubes.
Write a script to generate cubes.
Step 1: Create a new project in Unity
Open Unity and create a new 3D project.

Step 2: Create an empty GameObject
In the hierarchy of the scene, right-click and select Create Empty, then rename it to TerrainGenerator.

Step 3: Create the material
In the Assets folder, right-click and select Create -> Material.
Rename the material to GreenMaterial.
In the inspector, change its color to green.
Step 4: Write a script
In the Assets folder, create a Scripts folder.
Inside the Scripts folder, right-click and select Create -> C# Script. Call it TerrainGenerator.
Open the script and replace its contents with the following code:
csharp
Copy the code
using UnityEngine;

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
Go back to Unity and create a cube prefab:

In the hierarchy of the scene, right-click and select 3D Object -> Cube.
Drag the created cube to the Assets folder to create a prefab.
Remove the cube from the scene hierarchy.
Drag the created cube prefab and the GreenMaterial material to the appropriate fields in the TerrainGenerator inspector.
