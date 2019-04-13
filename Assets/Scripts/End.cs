using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{

    // Update is called once per frame
    void Update()
    {
        // restart the game when the spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Gameplay");
        }
        
    }
}
