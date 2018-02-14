using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class sfera_8_animController : MonoBehaviour {

	public Animator Sphere_8;

	public VideoPlayer video_s_8;

	void Awake(){

		video_s_8.GetComponent<VideoPlayer> ();
	}

	// Use this for initialization
	void Start () {

		Sphere_8 = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {

		if (Input.GetKeyDown ("x")) {			
			video_s_8.Stop ();
			Sphere_8.enabled = false;

		}

		if (Input.GetKeyDown ("c")) {			
			video_s_8.Stop ();
			Sphere_8.enabled = false;

		}

		if (Input.GetKeyDown ("v")) {			
			video_s_8.Stop ();
			Sphere_8.enabled = false;

		}

		if (Input.GetKeyDown ("b")) {			
			video_s_8.Stop ();
			Sphere_8.enabled = false;

		}

		if (Input.GetKeyDown ("d")) {			
			video_s_8.Stop ();
			Sphere_8.enabled = false;

		}
		if (Input.GetKeyDown ("f")) {			
			video_s_8.Stop ();
			Sphere_8.enabled = false;

		}
		if (Input.GetKeyDown ("g")) {			
			video_s_8.Stop ();
			Sphere_8.enabled = false;

		}
		if (Input.GetKeyDown ("h")) {

			video_s_8.Play ();
			Sphere_8.Play("sfera_8_animation");

		}
	}
}
