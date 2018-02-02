using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GUILifeFirstEnemy : MonoBehaviour {

    private GameObject guiEnemyLife;
    private GameObject guiPlayerLife;
    private GameObject guiPowerUps;


    public Text proiettili;                      
    private int count;

    void Start()
    {
        guiPlayerLife = GameObject.Find("Enemy");
        guiEnemyLife = GameObject.Find("Life");
        guiPowerUps = GameObject.Find("PowerUps");
        guiEnemyLife.SetActive(false);
        guiPlayerLife.SetActive(false);
        guiPowerUps.SetActive(false);
        count = 0;
        SetText();
    }


    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            guiPlayerLife.SetActive(true);
            guiEnemyLife.SetActive(true);
            guiPowerUps.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            guiPlayerLife.SetActive(false);
            guiEnemyLife.SetActive(false);
            guiPowerUps.SetActive(false);
        }
    }

    public void updateProiettili(int i)
    {
        count = count + i;
        if (count<=0)
        {
            count = 0;
        }
        SetText();
    }

    void SetText()
    {
        proiettili.text = count.ToString();
    }
    public int GetText()
    {
        return count;
    }
}

