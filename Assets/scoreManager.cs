using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class scoreManager : MonoBehaviour
{
    public TextMeshProUGUI LeftScoreText;
    public TextMeshProUGUI RightScoreText;

    public int LeftScore;
    public int RightScore;

    private void Start()
    {
        LeftScore = 0;
        RightScore = 0;

        LeftScoreText.text = LeftScore.ToString();
        RightScoreText.text = RightScore.ToString();
    }

    public void IncrementLeftPlayerScore()
    {
        LeftScore++;
        LeftScoreText.text = LeftScore.ToString();
    }

    public void IncrementRightPlayerScore()
    {
        RightScore++;
        RightScoreText.text = RightScore.ToString() ;
    }
}
