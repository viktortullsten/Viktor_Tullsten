using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Restart : MonoBehaviour {

   

    public GameObject gameOverText, restartButton;
   
    public float GameOverSpeed = 0f;
    public int noMovement;

  
   

    // Use this for initialization
    void Start ()
    {
        
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
        Time.timeScale = 1f;
        // Game over texten + restart knappen är avstängd.
    }
	
	// Update is called once per frame
	void Update ()
    {

    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        
        if (collision.gameObject.tag=="fiende")
        {
            print("GameOver");
            gameOverText.SetActive(true);
            restartButton.SetActive(true);
            //gameObject.SetActive(false);
            Time.timeScale = GameOverSpeed;
            noMovement++;
            
             
           

        }
    }
    // Om player nuddar fiende visas Game over texten i rutan + en restart knapp.
    // Stänger av rörligheten på player. 
}
