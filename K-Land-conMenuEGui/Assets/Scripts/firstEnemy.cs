using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstEnemy : MonoBehaviour {
    public GameObject gui;
    // Use this for initialization
    void Start()
    {
        gui = GameObject.Find("PrimoNemico");
        gui.SetActive(false);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gui.SetActive(true);
        }
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gui.SetActive(false);
        }
    }
}
