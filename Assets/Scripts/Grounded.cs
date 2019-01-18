using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grounded : MonoBehaviour
{  // En variabel som är beroende av vad resten av scriptet får för värde. 
    public int touches;
    
    //Om Grounded collidern colliderar med en annan collider kommer touches bli 1 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        touches = 1;
    }
   
    //Om Grounded collidern inte colliderar med en annan collider(spelaren är i luften) Kommer touches vara -1.
    private void OnTriggerExit2D(Collider2D collision)
    {
        touches = 0;
    }

}







