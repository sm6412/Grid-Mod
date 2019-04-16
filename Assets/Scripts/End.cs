using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class End : MonoBehaviour
{
    float progressControllerPos;

    float[] B1Range = new float[2];
    float[] B2Range = new float[2];
    float[] A1Range = new float[2];
    float[] A2Range = new float[2];


    [Header("Amphibian Sprites")]
    public Sprite sprite1;
    public Sprite sprite2;
    public Sprite sprite3;
    public Sprite sprite4;
    public Sprite sprite5;

    [Header("Bird Sprites")]
    public Sprite sprite6;
    public Sprite sprite7;
    public Sprite sprite8;
    public Sprite sprite9;
    public Sprite sprite10;

    [Header("Mammal Sprites")]
    public Sprite sprite11;
    public Sprite sprite12;
    public Sprite sprite13;
    public Sprite sprite14;
    public Sprite sprite15;

    [Header("Reptiles Sprites")]
    public Sprite sprite16;
    public Sprite sprite17;
    public Sprite sprite18;
    public Sprite sprite19;
    public Sprite sprite20;

    [Header("Fish Sprites")]
    public Sprite sprite21;
    public Sprite sprite22;
    public Sprite sprite23;
    public Sprite sprite24;
    public Sprite sprite25;

    [Header("Fun Facts")]
    public List<string> funFacts = new List<string>();

    private SpeciesTracker st;

    public SpriteRenderer speciesSR;

    private void Start()
    {

        progressControllerPos = ProgressController.currentY;
        // figure out score
        //FindScore(progressControllerPos);

        // get the species with the higest matches
        st = GameObject.Find("Species Tracker").GetComponent<SpeciesTracker>();
        DisplaySpecies(st.MostSpecies());

    }
    // Update is called once per frame
    void Update()
    {
        // restart the game when the spacebar is pressed
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SceneManager.LoadScene("Gameplay");
        }
        
    }

    void FindScore(float pos)
    {

    }

    void DisplaySpecies(int type)
    {
        if (type == 0)
        {
            speciesSR.sprite = sprite1;
        }
        else if (type == 1)
        {
            speciesSR.sprite = sprite2;
        }
        else if (type == 2)
        {
            speciesSR.sprite = sprite3;
        }
        else if (type == 3)
        {
            speciesSR.sprite = sprite4;
        }
        else if (type == 4)
        {
            speciesSR.sprite = sprite5;
        }

        // next animal group 
        else if (type == 5)
        {
            speciesSR.sprite = sprite6;
        }
        else if (type == 6)
        {
            speciesSR.sprite = sprite7;
        }
        else if (type == 7)
        {
            speciesSR.sprite = sprite8;
        }
        else if (type == 8)
        {
            speciesSR.sprite = sprite9;
        }
        else if (type == 9)
        {
            speciesSR.sprite = sprite10;
        }

        // next animal group
        else if (type == 10)
        {
            speciesSR.sprite = sprite11;
        }
        else if (type == 11)
        {
            speciesSR.sprite = sprite12;
        }
        else if (type == 12)
        {
            speciesSR.sprite = sprite13;
        }
        else if (type == 13)
        {
            speciesSR.sprite = sprite14;
        }
        else if (type == 14)
        {
            speciesSR.sprite = sprite15;
        }

        // next animal group
        else if (type == 15)
        {
            speciesSR.sprite = sprite16;
        }
        else if (type == 16)
        {
            speciesSR.sprite = sprite17;
        }
        else if (type == 17)
        {
            speciesSR.sprite = sprite18;
        }
        else if (type == 18)
        {
            speciesSR.sprite = sprite19;
        }
        else if (type == 19)
        {
            speciesSR.sprite = sprite20;
        }

        // last animal group
        else if (type == 20)
        {
            speciesSR.sprite = sprite21;
        }
        else if (type == 21)
        {
            speciesSR.sprite = sprite22;
        }
        else if (type == 22)
        {
            speciesSR.sprite = sprite23;
        }
        else if (type == 23)
        {
            speciesSR.sprite = sprite24;
        }
        else if (type == 24)
        {
            speciesSR.sprite = sprite25;
        }

    }
}
