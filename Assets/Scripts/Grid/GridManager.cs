using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [Header("Atributes")]
    public int width, height;
    public ButtonsManager tilePrefab;
    public float offset = 2f;

    [Header("Game Objects")]
    public Transform cam;

    private void Start() {
        CreateGrid(1);
    }
    // Start is called before the first frame update
    public void CreateGrid(int level) {
        for (int x = 0; x < width; x++) {
            for (int y = 0; y < height; y++) {
                var spawnedTile = Instantiate(tilePrefab, new Vector3(x*offset, y*offset), Quaternion.identity);
                spawnedTile.name = $"Tile {x} {y}";
            }
        }

        cam.transform.position = new Vector3((float)width / 2 - 0.5f, (float)height / 2 - 0.5f, -10);
    }
}
