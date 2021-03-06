﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class incontroGatto : MonoBehaviour
{
    public AudioSource song5;
    private GameObject spostamento_2_finegatto;
    private Vector3 mposition;
    private Quaternion mrotation;
    private GameObject unitychain;
    public GameObject InfoStregatto;
    public GameObject porta;
    public GameObject ramo;
    private bool isHere = false;
    private GameObject gatto;
    private Animator anim;
    private Animator anim_porta;
    private Animator tv2;
    public GameObject Tv;
    private Animator anim_ramo;
    private AnimatorStateInfo currentBaseState;
    public GameObject fine2;
    public GameObject portale;
    

    // private AnimatorStateInfo currentBaseState;
    static int idleState = Animator.StringToHash("Base Layer.gatto_fermo");
    static int animazione = Animator.StringToHash("Base Layer.gatto_animation");

    private void Start()
    {
        spostamento_2_finegatto = GameObject.Find("spostamento_2_finegatto");
        gatto = GameObject.Find("gatto");
        mposition = spostamento_2_finegatto.transform.position;
        mrotation = spostamento_2_finegatto.transform.rotation;
        unitychain = GameObject.FindGameObjectWithTag("Player");
        anim = gatto.GetComponent<Animator>();
        anim_porta=porta.GetComponent<Animator>();
        anim_ramo=ramo.GetComponent<Animator>();
        anim.Play("gatto_fermo");
        tv2 = Tv.GetComponent<Animator>();
        song5.GetComponent<AudioSource>();
    }

  void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InfoStregatto.SetActive(true);
            isHere = true;
            anim.SetBool("isHere",true);
            song5.Play();
            portale.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InfoStregatto.SetActive(false);
            isHere = false;
        }
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.P) && isHere)
        {
            unitychain.transform.SetPositionAndRotation(mposition, mrotation);
            anim.SetBool("isHere", true);
            anim_porta.SetBool("open",true);
            anim_ramo.Play("ramo_albero_animation");
            tv2.Play("tv_animation");
            fine2.SetActive(true);
        }
    }
}