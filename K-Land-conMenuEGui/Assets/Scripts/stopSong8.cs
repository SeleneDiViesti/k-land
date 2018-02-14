using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopSong8 : MonoBehaviour {

    public AudioSource song8;
	// Use this for initialization
	void Start () {
        song8.GetComponent<AudioSource>();
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            song8.Stop();
        }

    }
    // Update is called once per frame
    void Update () {
		
	}
}
