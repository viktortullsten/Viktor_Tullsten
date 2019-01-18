using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Goal : MonoBehaviour {
    public GameObject victory, restartButton;

    public float GameOverSpeed = 0f;
    public int noMovement;


    // Use this for initialization
    void Start()
    {
        victory.SetActive(false);
        restartButton.SetActive(false);

     // Stänger av victory texten och restart knappen i börgan. 

    }



// Update is called once per frame
void Update () {
		
	}
    private void OnCollisionEnter2D(Collision2D collision)
    {

        if (collision.gameObject.tag == "Player")
        {
           
            victory.SetActive(true);
            restartButton.SetActive(true);
            Time.timeScale = GameOverSpeed;
            noMovement++;

            // Sätter på victory texten + knappen när player träffar flaggan i slutet på bana 2. 
            // stänger också av rörlighetern på gubben.



        }
    }
}
