using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GUILifeFirstEnemy : MonoBehaviour {

    private GameObject guiEnemyLife;
    private GameObject guiPlayerLife;

    void Start()
    {
        guiPlayerLife = GameObject.Find("Enemy");
        guiEnemyLife = GameObject.Find("Life");
        guiEnemyLife.SetActive(false);
        guiPlayerLife.SetActive(false);
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            guiPlayerLife.SetActive(true);
            guiEnemyLife.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            guiPlayerLife.SetActive(false);
            guiEnemyLife.SetActive(false);
        }
    }
}

