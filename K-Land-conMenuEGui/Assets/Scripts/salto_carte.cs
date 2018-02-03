using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class salto_carte : MonoBehaviour
{

    //public GameObject salto_pos_carta;
    //public Vector3 mposition;
    //public Quaternion mrotation;
    public GameObject unitychain;
    public Vector3 scaleFactor = new Vector3(.3f, .3f, .3f);
    private Animator anim;
    private AnimatorStateInfo currentBaseState;
    private GameObject tappeto_molla;

    static int idleState = Animator.StringToHash("Base Layer.terra");
    static int animazione = Animator.StringToHash("Base Layer.molla_albero");

    public VideoPlayer video1;

    void Awake()
    {
        tappeto_molla = GameObject.Find("tappeto_molla");
        video1.GetComponent<VideoPlayer>();
        anim = tappeto_molla.GetComponent<Animator>();
        anim.Play("terra");
        unitychain = GameObject.FindGameObjectWithTag("Player");
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            //salto_pos_carta = GameObject.Find ("salto_pos_carta");
            //mposition = salto_pos_carta.transform.position;
            //mrotation = salto_pos_carta.transform.rotation;
            
            //unitychain.transform.SetPositionAndRotation (mposition, mrotation);
            unitychain.transform.localScale = scaleFactor;

            video1.Play();
            anim.SetBool("transition", true);

        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            anim.SetBool("transition", false);
        }
    }
}
