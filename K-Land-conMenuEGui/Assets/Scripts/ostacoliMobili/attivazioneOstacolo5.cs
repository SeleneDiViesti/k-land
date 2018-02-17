using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attivazioneOstacolo5 : MonoBehaviour {
    public GameObject Ostacolo1;
    public GameObject Ostacolo2;
    private Animator a1;
    private Animator a2;
    // Use this for initialization
    void Start()
    {
        a1 = Ostacolo1.GetComponent<Animator>();
        a2 = Ostacolo2.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            a1.Play("ostacolo5");
            a2.Play("ostacolo5_1");
        }
    }
}
