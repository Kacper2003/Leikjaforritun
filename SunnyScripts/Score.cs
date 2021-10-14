using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Score : MonoBehaviour
{
    int scoreValue;
    Text score;

    public PlayerMovement2D controller;

    void Start()
    {
        score = GetComponent<Text>();
    }

    void Update()
    {
        scoreValue = controller.GetComponent<PlayerMovement2D> ().score;
        score.text = "SCORE: " + scoreValue;
    }
}
