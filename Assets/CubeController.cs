﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeController : MonoBehaviour {

    private float speed = -0.2f;

    private float deadLine = -10;

    AudioSource audioSource;

    public AudioClip audioClip;

    // Use this for initialization
    void Start()
    {
        audioSource = gameObject.GetComponent<AudioSource>();
    }	
	// Update is called once per frame
	void Update () {
        transform.Translate(this.speed, 0, 0);
        
        if (transform.position.x < this.deadLine)
        {
            Destroy(gameObject);
        }
	}
    private void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.tag == "cube" || other.gameObject.tag == "ground")
        {
            audioSource.PlayOneShot(audioClip , 1);
        }
    }
}
