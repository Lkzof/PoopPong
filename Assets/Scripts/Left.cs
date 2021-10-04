using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public bool direct;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.W)){
            rb.velocity = new Vector2(0, speed);
        }
        else if(Input.GetKey(KeyCode.S)){
            rb.velocity = new Vector2(0, -speed);
        }else{
            rb.velocity = new Vector2(0, 0);
        }
    }
}
