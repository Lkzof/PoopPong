using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Platform : MonoBehaviour

{
    public Rigidbody2D rb;
    public float speed;
    public bool direct;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.velocity = new Vector2(0, speed);
    }

    void OnTriggerEnter2D(Collider2D col){

        if(col.gameObject.name == "Ball"){
            return;
        }
        if (direct == true){
            direct = false;
            rb.velocity = new Vector2(0, speed);
        } else{
            direct = true;
            rb.velocity = new Vector2(0, -speed);
        }

    }

}