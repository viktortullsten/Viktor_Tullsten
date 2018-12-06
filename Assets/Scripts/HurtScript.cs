using System.Collections;
using System.Collections.Generic;
using UnityEngine;
// Tillåter c sharp att använda Unity SceneManagement 
using UnityEngine.SceneManagement;


public class HurtScript : MonoBehaviour
{ // Gör det möjligt att Ändra i Unity villken Scene som ska loadas när scriptet körs. 
    public string LevelToLoad = "GameMap1";
    // Om Collidern i Flag kolliderar med en annan collider. 
    private void OnCollisionEnter2D(Collision2D collision)
    {
        // Om collidern som kolliderar med fiende är Player kommer De printa GameOver och Loada den scene som LevleToLoad är inställd på. 
        if (collision.gameObject.tag == "Player")
        {
            print("GameOver");
            SceneManager.LoadScene(LevelToLoad);
                
      
        }
        
        // Annars print Error i Console för att få veta att något gick fel. 
        else
        {
            print("error");
        }
    }
    
   

        
}

    
  
    
        
   


    // Use this for initialization
