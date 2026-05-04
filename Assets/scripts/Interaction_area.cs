using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction_area : MonoBehaviour
{
    public ScoreUIManager scoreUIMgr;

    void OnCollisionEnter(Collision col)
    {
        if(col.gameObject.CompareTag("pickable"))
        {
            Debug.Log("Hubo colicion con un pickable");
            Destroy(col.gameObject);
            scoreUIMgr.AddPointAndUpdateScoreUI();
        }
    }
}
