using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class sfera_7_animController : MonoBehaviour {
    private bool here = false;
    public Animator Sphere_7;

	public VideoPlayer video_s_7;


	void Awake(){

		video_s_7.GetComponent<VideoPlayer> ();

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
		
		Sphere_7 = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update () {
        if (here)
        {
            if (Input.GetKeyDown("x"))
            {
                video_s_7.Stop();
                Sphere_7.Play("fermo7");
                Sphere_7.enabled = false;

            }

            if (Input.GetKeyDown("c"))
            {
                video_s_7.Stop();
                Sphere_7.Play("fermo7");
                Sphere_7.enabled = false;

            }

            if (Input.GetKeyDown("v"))
            {
                video_s_7.Stop();
                Sphere_7.Play("fermo7");
                Sphere_7.enabled = false;

            }

            if (Input.GetKeyDown("b"))
            {
                video_s_7.Stop();
                Sphere_7.Play("fermo7");
                Sphere_7.enabled = false;

            }

            if (Input.GetKeyDown("d"))
            {
                video_s_7.Stop();
                Sphere_7.Play("fermo7");
                Sphere_7.enabled = false;

            }
            if (Input.GetKeyDown("f"))
            {
                video_s_7.Stop();
                Sphere_7.Play("fermo7");
                Sphere_7.enabled = false;

            }

            if (Input.GetKeyDown("g"))
            {
                Sphere_7.enabled = true;

                video_s_7.Play();
                Sphere_7.Play("sfera_7_animation");

            }
            if (Input.GetKeyDown("h"))
            {
                video_s_7.Stop();
                Sphere_7.Play("fermo7");
                Sphere_7.enabled = false;

            }

        }
	}
}
