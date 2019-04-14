using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridMaker : MonoBehaviour
{
    // scale 
    public float scaleAmount = 3f;

    // set the width and height of the grid
    public const int width = 5;
    public const int height = 7;

    public float first = 2f;
    public float second = 0.5f;

    // offset of x and y
    public float xOffset;
    public float yOffset;

    // two dimensional array 
    public GameObject[,] tiles;

    // two dimensional array of objects
    private int[,] tileVals;

    // holds tile sprite
    public GameObject tilePrefab;

    // an empty object to hold the grid
    public GameObject gridHolder;

    // Start is called before the first frame update
    void Start()
    {
         xOffset = width / first - second;
         yOffset = height / first - second;

    // instantiates the 2d array 
    tiles = new GameObject[width, height];
        tileVals = new int[width, height];

        gridHolder = new GameObject();
        gridHolder.transform.position = new Vector3(-1f, -0.5f, 0);


        for (int x=0; x < width; x++)
        {
            for(int y=0; y < height; y++)
            {
                // populate grid
                setNewTile(x, y);
            }
        }
        Destroy(tiles[2,3]);

        // ensure there are no matches in the start board 
        GameManager.Instance.checkGrid();
        
    }

    // creates new tile
    public void setNewTile(int x, int y)
    {
        GameObject newTile = Instantiate(tilePrefab);

        newTile.transform.parent = gridHolder.transform;

        // set the scale 
        Vector3 scale = new Vector3(scaleAmount, scaleAmount, 1f);
        newTile.transform.localScale = scale;

        // set the position 
        newTile.transform.localPosition = new Vector2(width - x - xOffset, height - y - yOffset);

        tiles[x, y] = newTile;

        Tile tileScript = newTile.GetComponent<Tile>();

        int randomVal = Random.Range(0, 6);
        tileScript.SetSprite(randomVal);

    }

    // return the grid width
    public int getWidth()
    {
        return width;
    }

    // return the grid height
    public int getHeight()
    {
        return height;
    }
}
