using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {

    public GameOverText Enemy;

    public GameObject gameOverText, restartButton;
    
    public float GameOverSpeed = 0.3f;
    public int noMovement;
    

    // Use this for initialization
    void Start ()
    {
        
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
        Time.timeScale = 1f;
        
    }
	
	// Update is called once per frame
	void Update ()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag=="Player")
        {
            print("GameOver");
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            //gameObject.SetActive(false);
            Time.timeScale = GameOverSpeed;
            noMovement++;


        }
    }

    
}
