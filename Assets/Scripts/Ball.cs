using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class Ball : MonoBehaviour

{
    public Rigidbody2D rb;
    public float x;
    public float y;
    public bool r_up;
    public bool r_down;
    public bool l_up;
    public bool l_down;
    public int p1 = 3;
    public int p2 = 3;
    private AudioSource sound;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        sound = GetComponent<AudioSource>();
        rb.velocity = new Vector2(x, y);
        r_up = true;
        r_down = false;
        l_up = false;
        l_down = false;

    }

    void Update(){
        if(p1 < 1){
            SceneManager.LoadScene("P2Win");
        }
        if(p2 < 1){
            SceneManager.LoadScene("P1Win");
        }
    }

    void OnTriggerEnter2D(Collider2D col){
        // Está indo pra direita e pra cima
        if (r_up == true){
            if(col.gameObject.name == "R2"){
                rb.velocity = new Vector2(-x, y);
                l_up = true;
                r_up = false;
                sound.Play();
            }else if(col.gameObject.name == "Y1"){
                rb.velocity = new Vector2(-x, y);
                l_up = true;
                r_up = false;    
                p2 -= 1; 
            }else if(col.gameObject.name == "X1"){
                rb.velocity = new Vector2(x, -y);
                r_up = false;
                r_down = true;
                sound.Play();
            }
        }
        // Está indo pra direita e pra baixo
        else if(r_down == true){
            if(col.gameObject.name == "R2"){
                rb.velocity = new Vector2(-x, -y);
                r_down = false;
                l_down = true;
                sound.Play();
            }else if(col.gameObject.name == "X2"){
                rb.velocity = new Vector2(x, y);
                r_down = false;
                r_up = true;
                sound.Play();
            }else if(col.gameObject.name == "Y1"){
                rb.velocity = new Vector2(-x, -y);
                r_down = false;
                l_down = true;
                p2 -= 1;
            }
        }
        // Está indo pra esquerda e pra baixo
        else if(l_down == true){
            if(col.gameObject.name == "R1"){
                rb.velocity = new Vector2(x, -y);
                r_down = true;
                l_down = false;
                sound.Play();
            }else if(col.gameObject.name == "X2"){
                rb.velocity = new Vector2(-x, y);
                l_up = true;
                l_down = false;
                sound.Play();

            }else if(col.gameObject.name == "Y2"){
                rb.velocity = new Vector2(x, -y);
                r_down = true;
                l_down = false;
                p1 -= 1;
            }
        }
        // Está indo pra esquerda e para cima
        else if(l_up == true){
            if(col.gameObject.name == "R1"){
                rb.velocity = new Vector2(x, y);
                r_up = true;
                l_up = false;
                sound.Play();
            }else if(col.gameObject.name == "Y2"){
                rb.velocity = new Vector2(x, y);
                r_up = true;
                l_up = false;
                p1 -= 1;

            }else if(col.gameObject.name == "X1"){
                rb.velocity = new Vector2(-x, -y);
                l_down = true;
                l_up = false;
                sound.Play();
            }
        }

    }


}