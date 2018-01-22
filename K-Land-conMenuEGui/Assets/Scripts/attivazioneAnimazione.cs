using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class attivazioneAnimazione : MonoBehaviour {
    public GameObject GuiCatapulta;
    public Animator anim;
    private bool isNear = false;
  
    // Use this for initialization
    void Start()
    {
        GuiCatapulta = GameObject.Find("GuiCatapulta");
        GuiCatapulta.SetActive(false);
        anim=this.GetComponent<Animator>();
        anim.Play("New State");
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z) && isNear==true)
        {
            anim.Play("catapulta_animation");
            
        }
    }
    

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GuiCatapulta.SetActive(true);
            isNear = true;
        }

    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GuiCatapulta.SetActive(false);
            isNear = false;
        }
    }
}
