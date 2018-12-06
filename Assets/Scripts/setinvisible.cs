using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class setinvisible : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        GetComponent<SpriteRenderer>().enabled = false;
    }


}
