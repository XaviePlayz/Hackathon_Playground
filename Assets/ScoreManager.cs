using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; 
    public Text scoreText;

    int score = 0;

    // Start is called before the first frame update
    void Start()
    {
        scoreText.text = score.ToString() + " POINTS";

        private void Awake() 
        {
            instance = this;
        }
    }

    public void AddPoint()
    {
        score += 1;
        scoreText.text = score.ToString() + " POINTS";
    }
}
