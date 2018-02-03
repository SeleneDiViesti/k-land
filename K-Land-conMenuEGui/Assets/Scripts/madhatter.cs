using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class madhatter : MonoBehaviour {
    public GameObject InfoCappellaio;
    private Animator anim;
    private AnimatorStateInfo currentBaseState;
    private GameObject madHatter;

    static int idleState = Animator.StringToHash("Base Layer.fermo");
    static int animazione = Animator.StringToHash("Base Layer.madhatter_animation");

    // Use this for initialization
    void Start()
    {
        madHatter = GameObject.Find("madhatter ");
        anim = madHatter.GetComponent<Animator>();
        anim.Play("fermo");
    }

    // Update is called once per frame
    void Update()
    {
        currentBaseState = anim.GetCurrentAnimatorStateInfo(0);
        if (Input.GetKeyDown(KeyCode.P))
        {
            if (currentBaseState.nameHash == idleState)
            {
                anim.SetBool("Alice", true);
                InfoCappellaio.SetActive(false);
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InfoCappellaio.SetActive(true);
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InfoCappellaio.SetActive(false);
        }
    }
}
