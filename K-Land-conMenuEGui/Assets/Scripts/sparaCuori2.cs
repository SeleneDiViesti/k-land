﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sparaCuori2 : MonoBehaviour {


    public GameObject GuiBacchetta;
    public GameObject ColliderInfoCuffie;
    public GameObject Gui;
    public GameObject bacchetta;
    private int numProiettili;

    //public Material newMaterialRef;

    private bool locked = true;
    private bool isNear = false;
       
    public Transform myTarget;  
    public Transform myPos;
    public GameObject cuore2;  

    public AudioSource sparo;

    
    private float t = 2f;
    
    // Use this for initialization
    void Start()
    {
        
    }

    
    void SimulateProjectile(GameObject cuore)
    {
        Vector3 forceDirection = myTarget.position - myPos.position;

        float X = forceDirection.x;         // Distance to travel along X : Space traveled @ time t
        float Y = forceDirection.y;         // Distance to travel along Y : Space traveled @ time t
        float Z = forceDirection.z;         // Distance to travel along Z : Space traveled @ time t

        float V0x = X / t;
        float V0z = Z / t;
        float V0y = (Y + (0.5f * Mathf.Abs(Physics.gravity.magnitude) * Mathf.Pow(t, 2))) / t;

        cuore.GetComponent<Rigidbody>().AddForce(Vector3.left * 7f, ForceMode.VelocityChange);
        cuore.GetComponent<Rigidbody>().AddForce(Vector3.up * V0y * 1f, ForceMode.VelocityChange);
        sparo.Play();
    }


    private void Update()
    {
        if (locked)
        {
            if (ColliderInfoCuffie.GetComponent<infoCuffie>().GetCuffie() >= 10)
            {
                unlock();
            }
        }
                
        if (isNear)
        {
            numProiettili = ColliderInfoCuffie.GetComponent<infoCuffie>().GetCuffie();
            if (Input.GetKeyDown(KeyCode.X) && numProiettili>0)
            
            {
                GameObject heart = Instantiate(cuore2, myPos.transform.position, myPos.transform.rotation, bacchetta.transform);
                
                SimulateProjectile(heart);
               
                ColliderInfoCuffie.GetComponent<infoCuffie>().updateCuffie(-1);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (!locked)
            {
                GuiBacchetta.SetActive(true);
                isNear = true;
            }
            else
            {
                Gui.SetActive(true);
            }
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GuiBacchetta.SetActive(false);
            Gui.SetActive(false);
            isNear = false;
        }
    }

    void unlock()
    {
        //bacchetta.GetComponent<MeshRenderer>().material = newMaterialRef;
        
        locked = false;
    }
}
