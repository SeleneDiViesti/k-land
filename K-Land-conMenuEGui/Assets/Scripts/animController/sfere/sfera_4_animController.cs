using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class sfera_4_animController : MonoBehaviour {
    private bool here = false;

    public Animator Sphere_4;

	public VideoPlayer video_s_4;


	void Awake(){
		
		video_s_4.GetComponent<VideoPlayer> ();

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
		
		Sphere_4 = GetComponent<Animator> ();

	}

    // Update is called once per frame
    void Update() {
        if (here)
        {
            if (Input.GetKeyDown("x")) {
                video_s_4.Stop();
                Sphere_4.Play("fermo4");
                Sphere_4.enabled = false;

            }

            if (Input.GetKeyDown("c")) {
                video_s_4.Stop();
                Sphere_4.Play("fermo4");
                Sphere_4.enabled = false;
            }

            if (Input.GetKeyDown("v")) {
                video_s_4.Stop();
                Sphere_4.Play("fermo4");
                Sphere_4.enabled = false;

            }
            if (Input.GetKeyDown("b")) {
                Sphere_4.enabled = true;

                video_s_4.Play();
                Sphere_4.Play("sfera_4_animation");

            }


            if (Input.GetKeyDown("d")) {
                video_s_4.Stop();
                Sphere_4.Play("fermo4");
                Sphere_4.enabled = false;

            }

            if (Input.GetKeyDown("f")) {
                video_s_4.Stop();
                Sphere_4.Play("fermo4");
                Sphere_4.enabled = false;

            }

            if (Input.GetKeyDown("g")) {
                video_s_4.Stop();
                Sphere_4.Play("fermo4");
                Sphere_4.enabled = false;

            }

            if (Input.GetKeyDown("h")) {
                video_s_4.Stop();
                Sphere_4.Play("fermo4");
                Sphere_4.enabled = false;

            }
        }
    }
}
