using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttivazioneOstacoli0 : MonoBehaviour {
    public GameObject Ostacolo1;
   
    private Animator a1;
    
    // Use this for initialization
    void Start()
    {
        a1 = Ostacolo1.GetComponent<Animator>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            a1.Play("ostacolo0");
           
        }
    }
}
