using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class HurtScript : MonoBehaviour
{
    public string LevelToLoad = "SampleScene";
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            print("GameOver");
            SceneManager.LoadScene(LevelToLoad);
                
      
        }
        else
        {
            print("error");
        }
    }
    
   

        
}

    
  
    
        
   


    // Use this for initialization
