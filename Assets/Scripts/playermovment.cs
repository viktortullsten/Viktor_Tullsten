using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class playermovment : MonoBehaviour
{
   

   // Bestäm hastighet genom att att sätta värde.
    [Range(0, 20f)]
    public float moveSpeed;
     
    // Bestäm hur högt spelaren ska hoppa genom att sätta värde.
    public float jumphight = 15f;
    // refererar till en Rigetbody genom rBody. 
    private Rigidbody2D rbody;
    //Refererar till Grounded scriptet genom groundCheck. 
    public Grounded groundCheck;
   
    public GameOverText Enemy;
    public float GameOverSpeed = 0.1f; 
    public GameObject gameOverText, restartButton;
    // Use this for initialization
    void Start()

    {// Bestämmer vilken Rigetbody som rBody ska referera till. 
        rbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {//Gör så att när man trycker ned a eller d genom att använda horizontal axis och multiplicera det med moveSpeed i en vector för att få spelaren att röra sig fram och bakåt.
        rbody.velocity = new Vector2(Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y);


        // Om man trycker ned Space kollar scriptet Grounded om collidern Grounded kolliderar med en annan collider för att veta om spelaren är på marken. Om spelaren är på marken använder den Jumphight värdet på y axeln för att få gubben att hoppa. 
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (groundCheck.touches > 0)
            {
                rbody.velocity = new Vector2(rbody.velocity.x, jumphight);

            }

        }
       
        




















    }
}
