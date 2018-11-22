using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FiendeHorizontalMovment : MonoBehaviour {
    public float moveSpeed = 2f;
    private Rigidbody2D rbody;
    public bool isLeft = true;
    public isGrounded Ground; 
    
    
    
    
    // Use this for initialization
	void Start () {
        rbody = GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (isLeft == true)
            rbody.velocity = new Vector2(-moveSpeed, rbody.velocity.y);
	}
    

}
