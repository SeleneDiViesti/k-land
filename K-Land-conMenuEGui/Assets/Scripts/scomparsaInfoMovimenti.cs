using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scomparsaInfoMovimenti : MonoBehaviour {
    public GameObject guiInfo;
    public GameObject guiSpille;
    public GameObject guiBenvenuto;
    // Use this for initialization
    void Start()
    {
        guiInfo = GameObject.Find("InfoMovimenti");
        guiBenvenuto = GameObject.Find("Benvenuto");
        guiSpille = GameObject.Find("InfoLabirintoESpille");
        guiSpille.SetActive(false);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            guiInfo.SetActive(false);
            guiBenvenuto.SetActive(false);
            guiSpille.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            guiSpille.SetActive(false);
        }
    }
}
