using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class infoCappellaio2 : MonoBehaviour {
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

    // Update is called once per frame
    void Update () {
		
	}
}
