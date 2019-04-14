using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgressController : MonoBehaviour
{
    int score = 0;
    public float moveAmt;

    public void Update()
    {
        if (score != 0 && this.transform.position.x < -271.35f)
        {
            this.transform.position += new Vector3(0, moveAmt, 0);
            score--; 

        }
    }


    public void AdjustProgress(int newScore)
    {
        score = newScore;
    }

}
