﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]

public class sparaProiettile : MonoBehaviour {

    public GameObject GuiCatapulta;
    public GameObject Cannone;
    public GameObject CorpoCannone;

    private bool isNear = false;
    private bool isAvaible = false;
    private int numProiettili;
    private int i = 0;
    public Animator anim;
    public AnimatorStateInfo currentBaseState;

    static int idleState = Animator.StringToHash("Base Layer.New State");
    static int animazione = Animator.StringToHash("Base Layer.cannone_animation");

    public Transform myTarget;  // drag the target here
    public Transform myPos;
    public GameObject projecticle;  // drag the cannonball prefab here

    private List<GameObject> palle;

    //private float firingAngle = 45.0f;
    //private float gravity = 9.8f;
    private float t = 2f;


    // Use this for initialization
    void Start()
    {

        CorpoCannone = GameObject.Find("CorpoCannone");
       // GuiCatapulta = GameObject.Find("GuiCatapulta");
        Cannone = GameObject.Find("Cannone");
        GuiCatapulta.SetActive(false);
        anim = CorpoCannone.GetComponent<Animator>();
        //string stringa = GameObject.Find("Count Text").ToString();
        //numProiettili = int.Parse(stringa);
        numProiettili = 10;

        palle = new List<GameObject>();
        //StartCoroutine(SimulateProjectile());
        anim.Play("New State");

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

        palla.GetComponent<Rigidbody>().AddForce(Vector3.left * 10f, ForceMode.VelocityChange); 
        palla.GetComponent<Rigidbody>().AddForce(Vector3.up * V0y* 1.2f , ForceMode.VelocityChange);
    }


    private void FixedUpdate()
    {
        currentBaseState = anim.GetCurrentAnimatorStateInfo(0);
        if (isNear)
        {
            if (Input.GetKeyDown(KeyCode.C) && numProiettili > 0)
            {
                if (currentBaseState.nameHash == idleState)
                {
                    anim.SetBool("cKey", true);
                }
                GameObject palla;
                //GameObject palla = Instantiate(projecticle, myPos.transform.position, myPos.transform.rotation, Catapulta.transform);
                palla = Instantiate(projecticle, myPos.transform.position, myPos.transform.rotation, Cannone.transform);
                palle.Add(palla);
                numProiettili = numProiettili - 1;
                isAvaible = true;
                i++;
            }

            if (Input.GetKeyDown(KeyCode.X) && isAvaible)
            {

                 SimulateProjectile(palle[i - 1]);
                    // palla.GetComponent<Rigidbody>().velocity = BallisticVel(myTarget, shootAngle);
                    // Destroy(ball, 10);
                 isAvaible = false;
                 anim.SetBool("cKey", false);
            }
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