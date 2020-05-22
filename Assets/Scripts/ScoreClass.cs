using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreClass : MonoBehaviour
{
    public GameObject scorescript;
    public int scorenum = 0;
    private void Start()
    {
        scorescript.GetComponent<AddScore>().updatescore(scorenum);
    }

    public void Changescore(int scoreno)
    {
        scorenum = scoreno;
        scorenum++;
        returnscore();
    }

    void returnscore()
    {
        scorescript.GetComponent<AddScore>().scoreup(scorenum);
    }
}
