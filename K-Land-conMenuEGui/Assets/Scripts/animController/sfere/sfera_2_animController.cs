using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class sfera_2_animController : MonoBehaviour {

	public Animator Sphere_2;

	public VideoPlayer video_s_2;


	void Awake(){

		video_s_2.GetComponent<VideoPlayer> ();
	
	}

	// Use this for initialization
	void Start () {
		
		Sphere_2 = GetComponent<Animator> ();

	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("x")) {			
			video_s_2.Stop ();
			Sphere_2.enabled = false;

		}

		if (Input.GetKeyDown ("c")) {
			
			video_s_2.Play ();
		
			Sphere_2.Play("sfera_2_animation");
		}

		if (Input.GetKeyDown ("v")) {			
			video_s_2.Stop ();
			Sphere_2.enabled = false;

		}

		if (Input.GetKeyDown ("b")) {			
			video_s_2.Stop ();
			Sphere_2.enabled = false;

		}

		if (Input.GetKeyDown ("d")) {			
			video_s_2.Stop ();
			Sphere_2.enabled = false;

		}

		if (Input.GetKeyDown ("f")) {			
			video_s_2.Stop ();
			Sphere_2.enabled = false;

		}

		if (Input.GetKeyDown ("g")) {			
			video_s_2.Stop ();
			Sphere_2.enabled = false;

		}

		if (Input.GetKeyDown ("h")) {			
			video_s_2.Stop ();
			Sphere_2.enabled = false;

		}
	}
}
