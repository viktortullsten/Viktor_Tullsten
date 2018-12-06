using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverText : MonoBehaviour
{

    public int Hit;


    private void OnTriggerEnter2D(Collider2D collision)
    {
        Hit++; 
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        Hit--;
    }

}
