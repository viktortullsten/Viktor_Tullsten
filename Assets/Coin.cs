using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    public int score = 1;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            GameObject controller = GameObject.FindWithTag("GameController");
            if (controller != null)
            {
                Scoretracker tracker = controller.GetComponent<Scoretracker>();
                if(tracker != null)
                {
                    tracker.totalScore += score;
                }
                else
                {
                    Debug.LogError("Scoretracker fattas.");
                }
            }
            Destroy(gameObject);
        }
    }
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
