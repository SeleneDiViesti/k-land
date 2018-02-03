using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class incontroGatto : MonoBehaviour
{

    private GameObject spostamento_2_finegatto;
    private Vector3 mposition;
    private Quaternion mrotation;
    private GameObject unitychain;
    public GameObject InfoStregatto;
    private bool isHere = false;
    private GameObject gatto;
    private Animator anim;
    private AnimatorStateInfo currentBaseState;
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
        anim.Play("gatto_fermo");
    }

        void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InfoStregatto.SetActive(true);
            isHere = true;
            anim.SetBool("isHere",true);
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
        }
    }
}