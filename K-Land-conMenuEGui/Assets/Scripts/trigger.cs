using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour {

    GameObject player;
    

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        
	}
    void OnTriggerEnter(Collider other)
    {
        //Debug.Log("trigger");
       if (other.CompareTag("Player"))
       player.GetComponent<PlayerLife>().TakeDamage(8);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
