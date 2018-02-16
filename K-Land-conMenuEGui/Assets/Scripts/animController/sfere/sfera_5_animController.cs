using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class sfera_5_animController : MonoBehaviour {
    private bool here = false;
    public Animator Sphere_5;

	public VideoPlayer video_s_5;

	void Awake(){

		video_s_5.GetComponent<VideoPlayer> ();
	
	}
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            here = true;
        }
    }
    // Use this for initialization
    void Start () {

		Sphere_5 = GetComponent<Animator> ();
	
	}

	// Update is called once per frame
	void Update () {
        if (here)
        {
            if (Input.GetKeyDown("x"))
            {
                video_s_5.Stop();
                Sphere_5.Play("fermo5");
                Sphere_5.enabled = false;

            }

            if (Input.GetKeyDown("c"))
            {
                video_s_5.Stop();
                Sphere_5.Play("fermo5");
                Sphere_5.enabled = false;

            }

            if (Input.GetKeyDown("v"))
            {
                video_s_5.Stop();
                Sphere_5.Play("fermo5");
                Sphere_5.enabled = false;

            }

            if (Input.GetKeyDown("b"))
            {
                video_s_5.Stop();
                Sphere_5.Play("fermo5");
                Sphere_5.enabled = false;

            }

            if (Input.GetKeyDown("d"))
            {
                Sphere_5.enabled = true;

                video_s_5.Play();
                Sphere_5.Play("sfera_5_animation");

            }

            if (Input.GetKeyDown("f"))
            {
                video_s_5.Stop();
                Sphere_5.Play("fermo5");
                Sphere_5.enabled = false;

            }

            if (Input.GetKeyDown("g"))
            {
                video_s_5.Stop();
                Sphere_5.Play("fermo5");
                Sphere_5.enabled = false;

            }

            if (Input.GetKeyDown("h"))
            {
                video_s_5.Stop();
                Sphere_5.Play("fermo5");
                Sphere_5.enabled = false;

            }
        }
	}
}
