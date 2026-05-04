using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreUIManager : MonoBehaviour
{
    public int Score = 0;
    // Start is called before the first frame update
    void Start()
    {

    }

    public void AddPointAndUpdateScoreUI()
    {
        Score ++;
        Debug.Log("Puntaje: " + Score);
    }
}
