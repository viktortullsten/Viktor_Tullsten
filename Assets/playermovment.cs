using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]

public class playermovment : MonoBehaviour
{
    [Range(0, 20f)]
    public float moveSpeed;

    public float jumphight;

    private Rigidbody2D rbody;

    public Grounded groundCheck;

    public GameObject gameOverText, restartButton, boold;
    // Use this for initialization
    void Start()
    {
        gameOverText.SetActive(false);
        restartButton.SetActive(false);
        rbody = GetComponent<Rigidbody2D>();

    }

    // Update is called once per frame
    void Update()
    {
        rbody.velocity = new Vector2(
            Input.GetAxisRaw("Horizontal") * moveSpeed, rbody.velocity.y);

        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (groundCheck.touches > 0)
            {
                rbody.velocity = new Vector2(rbody.velocity.x, jumphight);
            }

        }
        
      
            if (gameObject.tag.Equals("Enemy"))
            {
                gameOverText.SetActive(true);
                restartButton.SetActive(true);
                gameObject.SetActive(false);    
            }
        

    }
}
