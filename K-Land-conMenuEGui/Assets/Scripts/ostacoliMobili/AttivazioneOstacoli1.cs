using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AttivazioneOstacoli1 : MonoBehaviour {

    public GameObject Ostacolo1;
    public GameObject Ostacolo2;
    private Animator a1;
    private Animator a2;
    // Use this for initialization
    void Start () {
        a1 = Ostacolo1.GetComponent<Animator>();
        a2 = Ostacolo2.GetComponent<Animator>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        {
            a1.Play("ostacoliDalBasso");
            a2.Play("ostacoloMobile2");
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
