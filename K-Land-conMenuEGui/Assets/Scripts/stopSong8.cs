using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class stopSong8 : MonoBehaviour {

    public AudioSource song8;
    public GameObject gui;
	// Use this for initialization
	void Start () {
        song8.GetComponent<AudioSource>();
	}

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            song8.Stop();
            gui.SetActive(true);
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {            
            gui.SetActive(false);
        }

    }
    // Update is called once per frame
    void Update () {
		
	}
}
