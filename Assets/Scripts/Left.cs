using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Left : MonoBehaviour
{
    public Rigidbody2D rb;
    public float speed;
    public bool direct;
    public bool top = false;
    public bool bottom = false;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }


    // Update is called once per frame
    void Update()
    {

        if(top == true){
            rb.velocity = new Vector2(0, -speed);
        } 

        if(bottom == true){
            rb.velocity = new Vector2(0, speed);
        } 


        if(top == false && bottom == false){
            if(Input.GetKey(KeyCode.W)){
            rb.velocity = new Vector2(0, speed);
        
        }   else if(Input.GetKey(KeyCode.S)){
            rb.velocity = new Vector2(0, -speed);
        }
        
        else{
            rb.velocity = new Vector2(0, 0);
        }
        }
        
    }
    void OnTriggerEnter2D(Collider2D col){

        if(col.gameObject.name == "X1"){
            top = true;
        }

        if(col.gameObject.name == "X2"){
            bottom = true;
        }


    }
    void OnTriggerExit2D(Collider2D col){

        if(col.gameObject.name == "X1"){
            top = false;
        }

        if(col.gameObject.name == "X2"){
            bottom = false;
        }


    }

}
