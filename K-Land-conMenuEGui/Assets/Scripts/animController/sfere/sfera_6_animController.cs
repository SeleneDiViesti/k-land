using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class sfera_6_animController : MonoBehaviour {
    private bool here = false;

    public Animator Sphere_6;

	public VideoPlayer video_s_6;


	void Awake(){

		video_s_6.GetComponent<VideoPlayer> ();
	
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

		Sphere_6 = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update () {
        if (here)
        {
            if (Input.GetKeyDown("x"))
            {
                video_s_6.Stop();
                Sphere_6.Play("fermo6");
                Sphere_6.enabled = false;

            }

            if (Input.GetKeyDown("c"))
            {
                video_s_6.Stop();
                Sphere_6.Play("fermo6");
                Sphere_6.enabled = false;

            }

            if (Input.GetKeyDown("v"))
            {
                video_s_6.Stop();
                Sphere_6.Play("fermo6");
                Sphere_6.enabled = false;

            }

            if (Input.GetKeyDown("b"))
            {
                video_s_6.Stop();
                Sphere_6.Play("fermo6");
                Sphere_6.enabled = false;

            }

            if (Input.GetKeyDown("d"))
            {
                video_s_6.Stop();
                Sphere_6.Play("fermo6");
                Sphere_6.enabled = false;

            }

            if (Input.GetKeyDown("f"))
            {
                Sphere_6.enabled = true;

                video_s_6.Play();
                Sphere_6.Play("sfera_6_animation");

            }

            if (Input.GetKeyDown("g"))
            {
                video_s_6.Stop();
                Sphere_6.Play("fermo6");
                Sphere_6.enabled = false;

            }

            if (Input.GetKeyDown("h"))
            {
                video_s_6.Stop();
                Sphere_6.Play("fermo6");
                Sphere_6.enabled = false;

            }
        }
	}
}
