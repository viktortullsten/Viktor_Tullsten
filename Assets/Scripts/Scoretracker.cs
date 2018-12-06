using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro; 
public class Scoretracker : MonoBehaviour {
    public int totalScore;
    // Use this for initialization
    public TextMeshProUGUI scoreText; 
   


    private void Update()
    {
        scoreText.text = string.Format("score: {0}", totalScore); 
    }
}
