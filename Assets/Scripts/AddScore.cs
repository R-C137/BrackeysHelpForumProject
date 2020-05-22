using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AddScore : MonoBehaviour
{
    int scorenum = 0;
    public Text score;
    public GameObject scorechanger;
    int scorenumber;

    void Update()
    { 
       score.text = scorenum.ToString();
    }

    private void OnTriggerEnter(Collider other)
    {
        var c = scorechanger.GetComponent<ScoreClass>();
        if (other.gameObject.tag == "Player")
        {

            c.Changescore(scorenum);
        }
    }

    public void updatescore(int num)
    {
        scorenum = num;
    }

    public void scoreup(int no)
    {
        scorenumber = no;
        upgradescore();
    }
    
    void upgradescore()
    {
        scorenum++;
        scorechanger.GetComponent<ScoreClass>().Changescore(scorenumber);
    }


}
