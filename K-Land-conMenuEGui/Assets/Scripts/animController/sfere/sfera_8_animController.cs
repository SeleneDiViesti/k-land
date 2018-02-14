using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class sfera_8_animController : MonoBehaviour {

	public Animator Sphere_1;
	public Animator Sphere_2;
	public Animator Sphere_3;
	public Animator Sphere_4;
	public Animator Sphere_5;
	public Animator Sphere_6;
	public Animator Sphere_7;
	public Animator Sphere_8;

	public VideoPlayer video_s_1;
	public VideoPlayer video_s_2;
	public VideoPlayer video_s_3;
	public VideoPlayer video_s_4;
	public VideoPlayer video_s_5;
	public VideoPlayer video_s_6;
	public VideoPlayer video_s_7;
	public VideoPlayer video_s_8;

	void Awake(){
		video_s_1.GetComponent<VideoPlayer> ();
		video_s_2.GetComponent<VideoPlayer> ();
		video_s_3.GetComponent<VideoPlayer> ();
		video_s_4.GetComponent<VideoPlayer> ();
		video_s_5.GetComponent<VideoPlayer> ();
		video_s_6.GetComponent<VideoPlayer> ();
		video_s_7.GetComponent<VideoPlayer> ();
		video_s_8.GetComponent<VideoPlayer> ();
	}

	// Use this for initialization
	void Start () {
		Sphere_1 = GetComponent<Animator> ();
		Sphere_2 = GetComponent<Animator> ();
		Sphere_3 = GetComponent<Animator> ();
		Sphere_4 = GetComponent<Animator> ();
		Sphere_5 = GetComponent<Animator> ();
		Sphere_6 = GetComponent<Animator> ();
		Sphere_7 = GetComponent<Animator> ();
		Sphere_8 = GetComponent<Animator> ();
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("h")) {

			Sphere_1.Play ("fermo1");
			video_s_1.Stop ();

			Sphere_2.Play ("fermo2");
			video_s_2.Stop ();

			Sphere_3.Play ("fermo3");
			video_s_3.Stop ();

			Sphere_4.Play ("fermo4");
			video_s_4.Stop ();

			Sphere_5.Play ("fermo5");
			video_s_5.Stop ();

			Sphere_6.Play ("fermo6");
			video_s_6.Stop ();

			Sphere_7.Play ("fermo7");
			video_s_7.Stop ();

			//Sphere_8.enabled = true;

			video_s_8.Play ();
			Sphere_8.Play("sfera_8_animation");

		}
	}
}
