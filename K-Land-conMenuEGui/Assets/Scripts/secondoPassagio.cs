using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class secondoPassagio : MonoBehaviour
{

    public GameObject inizio3;
    public Vector3 mposition;
    public Quaternion mrotation;
    public GameObject unitychain;
    private Vector3 scaleFactor = new Vector3(1,1,1);

    // Update is called once per frame
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            inizio3 = GameObject.Find("inizio3");
            mposition = inizio3.transform.position;
            mrotation = inizio3.transform.rotation;
            unitychain = GameObject.FindGameObjectWithTag("Player");
            unitychain.transform.SetPositionAndRotation(mposition, mrotation);
            unitychain.transform.localScale = scaleFactor;
        }
    }
}