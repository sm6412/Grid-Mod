using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeciesTracker : MonoBehaviour
{
    public int[] numOfEachSpeciesOverWholeGame;
    // Start is called before the first frame update
    void Start()
    {
        // instantiate the species matched the most in the game
        numOfEachSpeciesOverWholeGame = new int[25];
        for (int i = 0; i < 25; i++)
        {
            numOfEachSpeciesOverWholeGame[i] = 0;
        }

    }

    public void updateSpecies(int pos)
    {
        numOfEachSpeciesOverWholeGame[pos]++;
    }

    public int MostSpecies()
    {
        int maxSpecies = numOfEachSpeciesOverWholeGame[0];
        int maxPos = 0;
        for (int i = 1; i < 25; i++)
        {
            int currentSpecies = numOfEachSpeciesOverWholeGame[i];
            if (currentSpecies > maxSpecies)
            {
                maxSpecies = currentSpecies;
                maxPos = i;
            }

        }
        return maxPos;
    }


}
