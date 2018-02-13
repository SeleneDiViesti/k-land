using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class audio_controller_1 : MonoBehaviour {

	public AudioSource song1;
	public AudioSource song2;

	// Use this for initialization
	void Awake () {
		song1.GetComponent<AudioSource> ();
		song2.GetComponent<AudioSource> ();
	}
	
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag("Player"))
		{
			song1.Stop ();
			song2.Play ();

		}
	}
}
