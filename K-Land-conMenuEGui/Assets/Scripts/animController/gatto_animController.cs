﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gatto_animController : MonoBehaviour {
	public Animator anim;
	// Use this for initialization
	void Start () {
		anim = GetComponent<Animator> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("3")) {
			anim.Play ("gatto_animation"); 
		}
	}
}