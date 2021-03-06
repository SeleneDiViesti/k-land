﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terzoPassagio : MonoBehaviour
{

    private GameObject inizio4;
    public GameObject bolla;
    private Vector3 mposition;
    private Quaternion mrotation;
    private GameObject unitychain;
    public AudioSource song7;
    public AudioSource song8;
    private Vector3 scaleFactor = new Vector3(.5f, .5f, .5f);

    void Start()
    {
        song7.GetComponent<AudioSource>();
        song8.GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inizio4 = GameObject.Find("inizio4");
            mposition = inizio4.transform.position;
            mrotation = inizio4.transform.rotation;
            unitychain = GameObject.FindGameObjectWithTag("Player");
            bolla.SetActive(false);
            unitychain.transform.SetPositionAndRotation(mposition, mrotation);
            unitychain.transform.localScale = scaleFactor;
            song7.Stop();
            song8.Play();
        }
    }
}