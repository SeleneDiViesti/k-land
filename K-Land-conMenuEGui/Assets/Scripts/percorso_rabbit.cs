using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class percorso_rabbit : MonoBehaviour {

	public GameObject rabbit_percorso;
	public Vector3 pos;

	//public Animator anim;

	// Use this for initialization
	void Start () {

	//	anim = GetComponent<Animator> ();	

		rabbit_percorso = GameObject.Find ("rabbit_percorso");

		pos = rabbit_percorso.transform.position;
	}
	
	// Update is called once per frame
	void Update () {
	//	anim.Play ("percorso_empty_rabbit"); 

		transform.position = pos;

	}
}
