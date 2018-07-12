using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour {

    int score = 0;

    public Text labelScore;

    public void AddScore()
    {
        score += 1;
        labelScore.text = "SCORE: " + score;
        //print("Add Score");
    }
}
