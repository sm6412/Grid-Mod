using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    // ref to gridmaker 
    private GridMaker gm;

    // player x and y pos
    float xPos;
    float yPos;

    // player matrix x and y position
    int matrixX;
    int matrixY;

    // amount of moves player can make
    public int moveNum;
    // ref to text that displays moves 
    public TextMesh moves;

    // bool to determine whether the player can move or not
    public bool canMove = true;

    // Start is called before the first frame update
    void Start()
    {
        // ref to grid maker 
        gm = GameObject.Find("Game Manager").GetComponent<GridMaker>();

        // initialize player position
        this.transform.parent = gm.gridHolder.transform;
        xPos = gm.getWidth() - 2 - gm.xOffset;
        yPos = gm.getHeight() - 3 - gm.yOffset;
        matrixX = 2;
        matrixY = 3;
        this.transform.localPosition = new Vector2(xPos,yPos);
        gm.tiles[2, 3] = this.gameObject;
        moves.text = moveNum.ToString();
    }

    // Update is called once per frame
    void Update()
    {
        // if moves run out, end game
        if (moveNum==0)
        {
            SceneManager.LoadScene("End");
        }

        // move player and determine switches
        if (canMove==true && (Input.GetKeyDown(KeyCode.DownArrow) || Input.GetKeyDown(KeyCode.S)) && ((matrixY+1)<gm.getHeight()))
        {
            moveNum--;
            moves.text = moveNum.ToString();
            switchDown();
        }
        else if (canMove==true && (Input.GetKeyDown(KeyCode.UpArrow) || Input.GetKeyDown(KeyCode.W)) && ((matrixY - 1) >= 0))
        {
            moveNum--;
            moves.text = moveNum.ToString();
            switchUp();
        }
        else if (canMove == true && (Input.GetKeyDown(KeyCode.RightArrow) || Input.GetKeyDown(KeyCode.D)) && ((matrixX - 1) >= 0))
        {
            moveNum--;
            moves.text = moveNum.ToString();
            switchRight();
        }
        else if (canMove == true && (Input.GetKeyDown(KeyCode.LeftArrow) || Input.GetKeyDown(KeyCode.A)) && ((matrixX + 1) < gm.getWidth()))
        {
            moveNum--;
            moves.text = moveNum.ToString();
            switchLeft();
        }
    }

    // update player position
    public void updatePlayerPos(int x, int y)
    {
        xPos = gm.getWidth() - x - gm.xOffset;
        yPos = gm.getHeight() - y - gm.yOffset;
        matrixX = x;
        matrixY = y;

    }

    // switch player with a tile underneath
    void switchDown()
    {
        GameObject tileToSwitch = gm.tiles[matrixX,matrixY+1];
        int xToCheck = matrixX;
        int yToCheck = matrixY;

        tileToSwitch.transform.localPosition = new Vector2(xPos, yPos);
        gm.tiles[matrixX, matrixY] = tileToSwitch;

        matrixY += 1;
        yPos = gm.getHeight() - matrixY - gm.yOffset;
        this.transform.localPosition = new Vector2(xPos, yPos);
        gm.tiles[matrixX, matrixY] = this.gameObject;

        GameManager.Instance.switchMatchCheck(xToCheck, yToCheck);
    }

    // switch player with the tile above
    void switchUp()
    {
        GameObject tileToSwitch = gm.tiles[matrixX, matrixY - 1];
        int xToCheck = matrixX;
        int yToCheck = matrixY;

        tileToSwitch.transform.localPosition = new Vector2(xPos, yPos);
        gm.tiles[matrixX, matrixY] = tileToSwitch;

        matrixY -= 1;
        yPos = gm.getHeight() - matrixY - gm.yOffset;
        this.transform.localPosition = new Vector2(xPos, yPos);
        gm.tiles[matrixX, matrixY] = this.gameObject;

        // check for matches
        GameManager.Instance.switchMatchCheck(xToCheck,yToCheck);

    }

    // switch player with the tile to the right of it
    void switchRight()
    {
        GameObject tileToSwitch = gm.tiles[matrixX - 1, matrixY];
        int xToCheck = matrixX;
        int yToCheck = matrixY;

        tileToSwitch.transform.localPosition = new Vector2(xPos, yPos);
        gm.tiles[matrixX, matrixY] = tileToSwitch;

        matrixX -= 1;
        xPos = gm.getWidth() - matrixX - gm.xOffset;
        this.transform.localPosition = new Vector2(xPos, yPos);
        gm.tiles[matrixX, matrixY] = this.gameObject;

        GameManager.Instance.switchMatchCheck(xToCheck, yToCheck);

    }

    // switch player with the tile to the left of it
    void switchLeft()
    {
        GameObject tileToSwitch = gm.tiles[matrixX + 1, matrixY];
        int xToCheck = matrixX;
        int yToCheck = matrixY;

        tileToSwitch.transform.localPosition = new Vector2(xPos, yPos);
        gm.tiles[matrixX, matrixY] = tileToSwitch;

        matrixX += 1;
        xPos = gm.getWidth() - matrixX - gm.xOffset;
        this.transform.localPosition = new Vector2(xPos, yPos);
        gm.tiles[matrixX, matrixY] = this.gameObject;

        GameManager.Instance.switchMatchCheck(xToCheck, yToCheck);

    }



    // turns movement on and off
    public void switchCanMove(bool res)
    {
        canMove = res;
    }
}
