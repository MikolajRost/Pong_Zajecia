using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using UnityEngine;

public class BulletBehaviour :  MonoBehaviour 
{ 
    public float Speed = 10f;
    private Rigidbody2D rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        
        if(transform.position.x < 0)
        {
            rb.velocity = new Vector2(Speed, rb.velocity.y);
        }
        else
        {
            rb.velocity = new Vector2(Speed, rb.velocity.y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.x < -15)
        {
            Destroy(this.gameObject);
        }
        if (transform.position.x > 15)
        {
            Destroy(this.gameObject);
        }
        

       
    }

}
