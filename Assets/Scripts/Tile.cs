using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tile : MonoBehaviour
{
    // type represents tile color
    public int type;

    // set tile color
    public void SetSprite(int rand)
    {
        type = rand;
        if (type == 0)
        {
            GetComponent<SpriteRenderer>().color = Color.red;
        }
        else if (type == 1)
        {
            GetComponent<SpriteRenderer>().color = Color.blue;
        }
        else if (type == 2)
        {
            GetComponent<SpriteRenderer>().color = Color.green;
        }
        else if (type == 3)
        {
            GetComponent<SpriteRenderer>().color = Color.yellow;
        }
        // orange
        else if (type == 4)
        {
            Color newColor;
            string hexString = "#ff6600";
            ColorUtility.TryParseHtmlString(hexString, out newColor);
            GetComponent<SpriteRenderer>().color = newColor;
        }
        // purple
        else if (type == 5)
        {
            Color newColor;
            string hexString = "#cc33ff";
            ColorUtility.TryParseHtmlString(hexString, out newColor);
            GetComponent<SpriteRenderer>().color = newColor;
        }


    }


}
