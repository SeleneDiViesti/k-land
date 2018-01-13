using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class terzoPassagio : MonoBehaviour
{

    public GameObject inizio4;
    public Vector3 mposition;
    public Quaternion mrotation;
    public GameObject unitychain;

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inizio4 = GameObject.Find("inizio4");
            mposition = inizio4.transform.position;
            mrotation = inizio4.transform.rotation;
            unitychain = GameObject.FindGameObjectWithTag("Player");
            unitychain.transform.SetPositionAndRotation(mposition, mrotation);
        }
    }
}