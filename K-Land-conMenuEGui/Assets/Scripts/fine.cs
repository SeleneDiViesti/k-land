using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fine : MonoBehaviour {
    public GameObject collider4;
    private bool isHere;
	// Use this for initialization
	void Start () {
		
	}
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           isHere = true;
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
           isHere = false;
        }
    }
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            collider4.GetComponent<infoLivello4>().loadGuiFine();
        }
 
   }
    
}
