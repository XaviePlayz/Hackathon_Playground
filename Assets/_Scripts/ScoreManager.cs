using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ScoreManager : MonoBehaviour
{
    public static ScoreManager instance; 
    public Text scoreText;

    public int score = 0;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;
    }

    void Start()
    {
        score = 0;
    }

    void Update()
    {
        scoreText.text = score.ToString() + " PTS";
    }
}
