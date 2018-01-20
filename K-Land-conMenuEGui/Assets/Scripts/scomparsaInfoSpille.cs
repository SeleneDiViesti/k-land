using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scomparsaInfoSpille : MonoBehaviour {
    public GameObject guiSpille;
    // Use this for initialization
    void Start () {
        guiSpille = GameObject.Find("InfoLabirintoESpille");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            guiSpille.SetActive(false);
        }
    }
}
