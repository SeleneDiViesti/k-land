using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terzoPassagio : MonoBehaviour
{

    private GameObject inizio4;
    public GameObject bolla;
    private Vector3 mposition;
    private Quaternion mrotation;
    private GameObject unitychain;
    public AudioSource audio;
    

    void Start()
    {
        audio.GetComponent<AudioSource>();
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
            audio.Stop();
        }
    }
}