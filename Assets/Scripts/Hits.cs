using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hits : MonoBehaviour
{
    private AudioSource sound;
    // Start is called before the first frame update
    void Start()
    {
        sound = GetComponent<AudioSource>();
    }

    void OnTriggerEnter2D(Collider2D col){

        sound.Play();


    }
}
