using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiendeHorizontalMovment : MonoBehaviour {
    // Ställ in ett värde som kommer användas för att beatämma hanstigheten i Unity.
    public float moveSpeed = 2f;
    bool reverse = true;
    private Rigidbody2D rbody;
    //Refererar till någon Rigetbody och kallar den rBody.  
    
    //Om Enemy ska till vänster. 
    public bool isLeft = true;
 
    
    
    
    
    // Use this for initialization
	void Start ()
        // Bestämmer vilken Rigetbody rBody ska referera till.
    {
        rbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {// Om spelaren ska åt vänster så använder den värdet -Movespeed i x axeln för att röra enemy till vänster.
    

        if (isLeft == true)
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);
	}

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Triggers")
        {
            isLeft = false;
        }
       
    }
    
}
