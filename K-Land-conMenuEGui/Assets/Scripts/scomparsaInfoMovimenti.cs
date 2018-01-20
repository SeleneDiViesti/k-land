using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scomparsaInfoMovimenti : MonoBehaviour {
    public GameObject guiInfo;
    public GameObject guiSpille;
    // Use this for initialization
    void Start()
    {
        guiInfo = GameObject.Find("InfoMovimenti");
        guiSpille = GameObject.Find("InfoLabirintoESpille");
        guiSpille.SetActive(false);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            guiInfo.SetActive(false);
            guiSpille.SetActive(true);
        }
    }
}
