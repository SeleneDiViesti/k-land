﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class sfera_1_animController : MonoBehaviour {
    private bool here = false;
    public Animator Sphere_1;

	public VideoPlayer video_s_1;

	void Awake(){
		video_s_1.GetComponent<VideoPlayer> ();
	}

	// Use this for initialization
	void Start () {
		Sphere_1 = GetComponent<Animator> ();
	
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            here = true;
            //Debug.Log("here");
        }
    }
    // Update is called once per frame
    void Update () {
        if (here)
        {
            if (Input.GetKeyDown("x"))
            {
                Sphere_1.enabled = true;
                video_s_1.Play();

                Sphere_1.Play("sfera_animation");
            }
            if (Input.GetKeyDown("c"))
            {
                video_s_1.Stop();
                Sphere_1.Play("fermo1");
                Sphere_1.enabled = false;
                
            }

            if (Input.GetKeyDown("v"))
            {
                video_s_1.Stop();
                Sphere_1.Play("fermo1");
                Sphere_1.enabled = false;
               
            }

            if (Input.GetKeyDown("b"))
            {
                video_s_1.Stop();
                Sphere_1.Play("fermo1");
                Sphere_1.enabled = false;
                
            }

            if (Input.GetKeyDown("d"))
            {
                video_s_1.Stop();
                Sphere_1.Play("fermo1");
                Sphere_1.enabled = false;
                
            }

            if (Input.GetKeyDown("f"))
            {
                video_s_1.Stop();
                Sphere_1.Play("fermo1");
                Sphere_1.enabled = false;
                
            }

            if (Input.GetKeyDown("g"))
            {
                video_s_1.Stop();
                Sphere_1.Play("fermo1");
                Sphere_1.enabled = false;
                
            }

            if (Input.GetKeyDown("h"))
            {
                video_s_1.Stop();
                Sphere_1.Play("fermo1");
                Sphere_1.enabled = false;

            }
        }
	}
}
