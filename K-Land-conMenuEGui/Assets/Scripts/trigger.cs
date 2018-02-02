using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trigger : MonoBehaviour {

    GameObject player;
    public ParticleSystem ps;

    // Use this for initialization
    void Start () {
        player = GameObject.FindGameObjectWithTag("Player");
        ps = GetComponent<ParticleSystem>();
	}
    void OnParticleTrigger()
    {
        //Debug.Log("trigger");
       // player.GetComponent<PlayerLife>().TakeDamage(10);
    }
    // Update is called once per frame
    void Update () {
		
	}
}
