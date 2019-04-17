using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressController : MonoBehaviour
{
    int score = 0;
    public float moveAmt;
    public static float currentY;

    private void Awake()
    {
        currentY = this.transform.position.y;
    }

    public void Update()
    {
        if (score != 0 && (this.transform.position.y+moveAmt) < 3.11)
        {
            this.transform.position += new Vector3(0, moveAmt, 0);
            currentY = this.transform.position.y;
            score--; 

        }
    }


    public void AdjustProgress(int newScore)
    {
        
        score = newScore;
    }

}
