using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class attiva_video_sfera : MonoBehaviour {

	public VideoPlayer video;
	public Animator anim;

	void Awake(){
		video.GetComponent<VideoPlayer> ();

	}

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			if (Input.GetKeyDown ("p")) {
				// animazione sfera 
				anim.Play("sfera_animation");
				video.Play ();
			}

		}
	}
}
