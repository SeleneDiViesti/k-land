using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bolla : MonoBehaviour {

    public GameObject colliderInfoCuffie;
    public GameObject player;
    
	// Use this for initialization
	void Start () {
		
	}

    // Update is called once per frame
    void Update()
    {
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("cuffie"))
        {
            colliderInfoCuffie.GetComponent<infoCuffie>().updateCuffie();
            other.enabled = false;
        }
    }
    //void OnTriggerEnter(Collider other)
    //{
    //    if (other.CompareTag("Player"))  //if other.compareTaf("armaRegina")  player.getComponent<PlayerLife>().TakeDamage(x);
    //    {
    //       // player.SetActive(false);
    //    }
    //}
    //void OnTriggerExit(Collider other)
    //{
    //    if (other.CompareTag("cuffie"))
    //    {
    //      colliderInfoCuffie.GetComponent<infoCuffie>().updateCuffie();
    //    }
    //}
}
