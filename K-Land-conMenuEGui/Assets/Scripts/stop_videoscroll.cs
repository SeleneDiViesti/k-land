using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class stop_videoscroll : MonoBehaviour {

	public GameObject collider;
	public GameObject unitychain;
	 
	public VideoPlayer video; 

	// se unitychan è sul collider dopo il video , cioè ha fatto skip 
	// bisogna fare lo stop del video e dell'audio in modo che cominci il prossimo 
	void OnTriggerEnter(Collider other)
	{
		

		if (other.CompareTag ("Player")) {
			collider= GameObject.Find ("collider_video");
			unitychain = GameObject.FindGameObjectWithTag ("Player");

			// trova il gameobgect che rappresenta il video 
			video = GameObject.FindObjectOfType<VideoPlayer>();
			// fermare il video
			video.Stop ();



		}
	}
}
