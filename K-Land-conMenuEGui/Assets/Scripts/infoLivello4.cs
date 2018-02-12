using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class infoLivello4 : MonoBehaviour {
    public GameObject gui;
    public GameObject guiFine;
    public GameObject player;
    public GameObject colliderInfoCuffie;
    public Text parzialeSpille;
    public Text parzialeVita;
    public Text punteggio;

    private bool isHere = false;
    private float tot;

    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return) && isHere)
        {
            loadGuiFine();
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gui.SetActive(true);
            isHere = true;
        }
        
    }
    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            gui.SetActive(false);
            isHere = false;
        }
    }
    void loadGuiFine()
    {
        int numeroSpille= player.GetComponent<UnityChanControlScriptWithRgidBody>().GetNumberSpille();
        float puntiVita= player.GetComponent<PlayerLife>().GetCurrentHealth();
        float puntiCuffie = colliderInfoCuffie.GetComponent<infoCuffie>().GetCuffie();
        puntiVita = puntiVita * 15+ puntiCuffie * 13;
        numeroSpille = numeroSpille * 10;
        float spille = (float)numeroSpille;
        tot = spille + puntiVita;
        parzialeSpille.text = spille.ToString();
        parzialeVita.text = puntiVita.ToString();
        punteggio.text = tot.ToString();
        guiFine.SetActive(true);   
    }
       
}
