using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class firstEnemy : MonoBehaviour {
    public GameObject gui;
    public GameObject rabbit;
    // Use this for initialization
    void Awake()
    {
        gui = GameObject.Find("PrimoNemico");
        gui.SetActive(false);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gui.SetActive(true);
            rabbit.SetActive(false);
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
