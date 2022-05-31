using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreHud : MonoBehaviour
{
    public static int scoreAmount;
    public Text scoreText;
    public Text winText;

    void Start()
    {
        scoreText = GetComponent<Text>();
        winText.text = "";
        scoreAmount = 0;
    }

    void Update()
    {
        scoreText.text = scoreAmount.ToString();
        if (scoreAmount >= 5)
        {
            //winText.text = "100% Collected";
        }
    }
}
