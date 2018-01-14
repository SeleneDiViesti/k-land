using System.Collections;
using System.Collections.Generic;
using UnityEngine;
public class primoPassaggio : MonoBehaviour
{

    public GameObject inizio2;
    public Vector3 mposition;
    public Quaternion mrotation;
    public GameObject unitychain;
    private Vector3 scaleFactor = new Vector3(.5f, .5f, .5f);

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
            unitychain.transform.localScale = scaleFactor;
        }
    }
}
