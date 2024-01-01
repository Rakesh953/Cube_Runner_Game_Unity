using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    public Text scoreText;
    public Text FinalScoreText;
    int myscore = 0;
    void Update()
    {
        scoreText.text = myscore.ToString();
        FinalScoreText.text ="Scr:"+myscore.ToString();
    }
    public void AddScore(int score)
    {
        myscore = myscore + score;
    }
}
