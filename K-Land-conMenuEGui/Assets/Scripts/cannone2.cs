﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]

public class cannone2 : MonoBehaviour
{

    public GameObject GuiCatapulta;
    public GameObject Cannone2;
    public GameObject CorpoCannone2;
    public GameObject ColliderInfoCaterpillarLife;
    public GameObject Gui;
    public GameObject unitychain;
    public GameObject baseCannone;
    //public GameObject base2Cannone;

   // public Material newMaterialRef;

    private bool locked = true;
    private bool isNear = false;
    private bool isAvaible = false;
    private int numProiettili;
    private int i = 0;
    public Animator anim2;
    public AnimatorStateInfo currentBaseState;

    static int idleState = Animator.StringToHash("Base Layer.New State2");
    static int animazione = Animator.StringToHash("Base Layer.cannone2_animation");

    public Transform myTarget;  // drag the target here
    public Transform myPos;
    public GameObject projecticle;  // drag the cannonball prefab here
    public AudioSource sparo;

    private float t = 2f;
    public GameObject ColliderInfoCaterpillar;

    // Use this for initialization
    void Start()
    {
        //CorpoCannone2 = GameObject.Find("CorpoCannone2");
        ////GuiCatapulta = GameObject.Find("GuiCatapulta");
        //Cannone2 = GameObject.Find("Cannone2");
        GuiCatapulta.SetActive(false);
        anim2 = CorpoCannone2.GetComponent<Animator>();
        
        //palle = new List<GameObject>();
        //StartCoroutine(SimulateProjectile());
        anim2.Play("New State2");
    }

    //IEnumerator SimulateProjectile()
    void SimulateProjectile(GameObject palla)
    {
        Vector3 forceDirection = myTarget.position - myPos.position;

        float X = forceDirection.x;         // Distance to travel along X : Space traveled @ time t
        float Y = forceDirection.y;         // Distance to travel along Y : Space traveled @ time t
        float Z = forceDirection.z;         // Distance to travel along Z : Space traveled @ time t

        float V0x = X / t;
        float V0z = Z / t;
        float V0y = (Y + (0.5f * Mathf.Abs(Physics.gravity.magnitude) * Mathf.Pow(t, 2))) / t;

        palla.GetComponent<Rigidbody>().AddForce(Vector3.forward * 10f, ForceMode.VelocityChange);
        palla.GetComponent<Rigidbody>().AddForce(Vector3.up * V0y * 1.2f, ForceMode.VelocityChange);
        sparo.Play();
    }


    private void FixedUpdate()
    {
        if (locked)
        {
            if (unitychain.GetComponent<UnityChanControlScriptWithRgidBody>().GetNumberSpille() >= 15)
            {
                unlock();
            }
        }
        
        currentBaseState = anim2.GetCurrentAnimatorStateInfo(0);
        
        if (isNear && !locked)
        {
            numProiettili= ColliderInfoCaterpillarLife.GetComponent<GUILifeFirstEnemy>().GetText();
            if (Input.GetKeyDown(KeyCode.C) && numProiettili > 0)
            {
               
                if (currentBaseState.nameHash == idleState)
                {
                    anim2.SetBool("cKey", true);
                }
                isAvaible = true;
               
            }

            if (Input.GetKeyDown(KeyCode.X) && isAvaible)
            {
                GameObject palla = Instantiate(projecticle, myPos.transform.position, myPos.transform.rotation, Cannone2.transform);

                SimulateProjectile(palla);

                isAvaible = false;
                anim2.SetBool("cKey", false);

                ColliderInfoCaterpillar.GetComponent<GUILifeFirstEnemy>().updateProiettili(-1);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if(!locked)
            {
                GuiCatapulta.SetActive(true);
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
            GuiCatapulta.SetActive(false);
            Gui.SetActive(false);
            isNear = false;
        }
    }

    void unlock()
    {
        //CorpoCannone2.GetComponent<MeshRenderer>().material= newMaterialRef;
        //baseCannone.GetComponent<MeshRenderer>().material = newMaterialRef;
        //base2Cannone.GetComponent<MeshRenderer>().material = newMaterialRef;
        locked = false;
    }
}

