using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoFineLivello2 : MonoBehaviour {
    public GameObject gui;
	// Use this for initialization
	void Start () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
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
