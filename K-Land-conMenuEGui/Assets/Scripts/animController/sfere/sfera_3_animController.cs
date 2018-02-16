using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class sfera_3_animController : MonoBehaviour {
    private bool here = false;

    public Animator Sphere_3;

	public VideoPlayer video_s_3;

	void Awake(){

		video_s_3.GetComponent<VideoPlayer> ();

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

		Sphere_3 = GetComponent<Animator> ();


	}

	// Update is called once per frame
	void Update () {
        if (here)
        {
            if (Input.GetKeyDown("x"))
            {
                video_s_3.Stop();
                Sphere_3.Play("fermo3");
                Sphere_3.enabled = false;

            }

            if (Input.GetKeyDown("c"))
            {
                video_s_3.Stop();
                Sphere_3.Play("fermo3");
                Sphere_3.enabled = false;

            }

            if (Input.GetKeyDown("v"))
            {
                Sphere_3.enabled = true;

                video_s_3.Play();
                // animazione sfera 
                Sphere_3.Play("sfera_3_animation");

            }

            if (Input.GetKeyDown("b"))
            {
                video_s_3.Stop();
                Sphere_3.Play("fermo3");
                Sphere_3.enabled = false;

            }

            if (Input.GetKeyDown("d"))
            {
                video_s_3.Stop();
                Sphere_3.Play("fermo3");
                Sphere_3.enabled = false;

            }

            if (Input.GetKeyDown("f"))
            {
                video_s_3.Stop();
                Sphere_3.Play("fermo3");
                Sphere_3.enabled = false;

            }

            if (Input.GetKeyDown("g"))
            {
                video_s_3.Stop();
                Sphere_3.Play("fermo3");
                Sphere_3.enabled = false;

            }

            if (Input.GetKeyDown("h"))
            {
                video_s_3.Stop();
                Sphere_3.Play("fermo3");
                Sphere_3.enabled = false;

            }
        }
	}
}
