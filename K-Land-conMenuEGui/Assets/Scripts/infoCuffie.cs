﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class infoCuffie : MonoBehaviour {

    public GameObject cuffie;
    public Text nCuffie;
    private int count;
    public GameObject guiPlayerLife;

    void Start()
    {
        guiPlayerLife.SetActive(false);
        count = 0;
        SetText();
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cuffie.SetActive(true);
            guiPlayerLife.SetActive(true);
        }

    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            cuffie.SetActive(false);
            guiPlayerLife.SetActive(false);
        }
    }
    public void updateCuffie()
    {
        count++;

        if (count <= 0)
        {
            count = 0;
        }
        SetText();
    }

    void SetText()
    {
        nCuffie.text = count.ToString();
    }
    public int GetCuffie()
    {
        return count;
    }

}
