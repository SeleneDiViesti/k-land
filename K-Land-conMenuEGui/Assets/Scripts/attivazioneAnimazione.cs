using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]

public class attivazioneAnimazione : MonoBehaviour {
    public GameObject GuiCatapulta;
    public GameObject braccio;
    private bool isNear = false;
    public Animator anim;
    public AnimatorStateInfo currentBaseState;

    static int idleState = Animator.StringToHash("Base Layer.New State");
    static int animazione = Animator.StringToHash("Base Layer.catapulta_animation");
   

    // Use this for initialization
    void Start()
    {
        braccio= GameObject.Find("braccioDellaCatapulta");
        GuiCatapulta = GameObject.Find("GuiCatapulta");
        GuiCatapulta.SetActive(false);
        anim= braccio.GetComponent<Animator>();
        
        //anim.Play("New State");
    }

    private void FixedUpdate()
    {
        currentBaseState = anim.GetCurrentAnimatorStateInfo(0);

        if (Input.GetKeyDown(KeyCode.Z) && isNear == true)
        {
            if (currentBaseState.nameHash == idleState)
            {
            anim.SetBool("zKey", true);
            }
        }

        //anim.Play("catapulta_animation");
        if (currentBaseState.nameHash == animazione)
        {
            if (!anim.IsInTransition(0))
            {
                anim.SetBool("zKey", false);
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
