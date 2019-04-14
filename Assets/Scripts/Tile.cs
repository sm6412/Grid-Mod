using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    // type represents tile color
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;
    public Sprite sprite6;

    public int type;

    // set tile color
    public void SetSprite(int rand)
    {
        type = rand;
        if (type == 0)
        {
            GetComponent<SpriteRenderer>().sprite = sprite1;
        }
        else if (type == 1)
        {
            GetComponent<SpriteRenderer>().sprite = sprite2;
        }
        else if (type == 2)
        {
            GetComponent<SpriteRenderer>().sprite = sprite3;
        }
        else if (type == 3)
        {
            GetComponent<SpriteRenderer>().sprite = sprite4;
        }
        else if (type == 4)
        {
            GetComponent<SpriteRenderer>().sprite = sprite5;
        }
        else if (type == 5)
        {
            GetComponent<SpriteRenderer>().sprite = sprite6;
        }


    }


}
