using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class primoPassaggio : MonoBehaviour
{

    public GameObject inizio2;
    public Vector3 mposition;
    public Quaternion mrotation;
    public GameObject unitychain;
    public AudioSource song3;
    public AudioSource song4;

    void Awake()
    {
        song3.GetComponent<AudioSource>();
        song4.GetComponent<AudioSource>();

    }
    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inizio2 = GameObject.Find("inizio2");
            mposition = inizio2.transform.position;
            mrotation = inizio2.transform.rotation;
            unitychain = GameObject.FindGameObjectWithTag("Player");
            unitychain.transform.SetPositionAndRotation(mposition, mrotation);
            song3.Stop();
            song4.Play();
        }
    }
}
