using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Animator))]

public class attivazioneAnimazione : MonoBehaviour {
    public GameObject GuiCatapulta;
    public GameObject Catapulta;
    public GameObject braccio;
    
    private bool isNear = false;
    private bool isAvaible = false;
    private int numProiettili;
    private int i=0;
    public Animator anim;
    public AnimatorStateInfo currentBaseState;

    static int idleState = Animator.StringToHash("Base Layer.New State");
    static int animazione = Animator.StringToHash("Base Layer.catapulta_animation");

    public Transform myTarget;  // drag the target here
    public Transform myPos;
    public GameObject projecticle;  // drag the cannonball prefab here

    private List<GameObject> palle;

    //private float firingAngle = 45.0f;
    //private float gravity = 9.8f;
    private float t =2f;


    // Use this for initialization
    void Start()
    {
        
        braccio = GameObject.Find("braccioDellaCatapulta");
        GuiCatapulta = GameObject.Find("GuiCatapulta");
        Catapulta = GameObject.Find("Catapulta");
        GuiCatapulta.SetActive(false);
        anim = braccio.GetComponent<Animator>();
        //string stringa = GameObject.Find("Count Text").ToString();
        //numProiettili = int.Parse(stringa);
        numProiettili = 10;

        palle=new List<GameObject>();
        //StartCoroutine(SimulateProjectile());
        //anim.Play("New State");

    }

    //IEnumerator SimulateProjectile()
    void SimulateProjectile(GameObject palla)
    {
        Vector3 forceDirection = myTarget.position- myPos.position;

        float X = forceDirection.x;         // Distance to travel along X : Space traveled @ time t
        float Y = forceDirection.y;         // Distance to travel along Y : Space traveled @ time t
        float Z = forceDirection.z;         // Distance to travel along Z : Space traveled @ time t
               
        float V0x = X / t;
        float V0z = Z / t;
        float V0y = (Y + (0.5f * Mathf.Abs(Physics.gravity.magnitude) * Mathf.Pow(t, 2))) / t;

        palla.GetComponent<Rigidbody>().AddForce(Vector3.left * 3f, ForceMode.VelocityChange); //TODO
        palla.GetComponent<Rigidbody>().AddForce(Vector3.up * V0y*1.5f, ForceMode.VelocityChange);
        //palla.GetComponent<Rigidbody>().AddForce(Vector3.forward * V0z, ForceMode.VelocityChange);

        // Calculate the velocity needed to throw the object to the target at specified angle.
        //float projectile_Velocity = target_Distance / (Mathf.Sin(2 * firingAngle * Mathf.Deg2Rad) / gravity);

        //// Extract the X  Y componenent of the velocity
        //float Vx = Mathf.Sqrt(projectile_Velocity) * Mathf.Cos(firingAngle * Mathf.Deg2Rad);
        //float Vy = Mathf.Sqrt(projectile_Velocity) * Mathf.Sin(firingAngle * Mathf.Deg2Rad);

        //// Calculate flight time.
        //float flightDuration = target_Distance / Vx;
        
    }


    private void FixedUpdate()
    {
        currentBaseState = anim.GetCurrentAnimatorStateInfo(0);
        if (isNear)
        {
            if (Input.GetKeyDown(KeyCode.C) && numProiettili>0)
            {
                GameObject palla;
                //palla = Instantiate(projecticle, myPos.transform.position, myPos.transform.rotation, Catapulta.transform);
                palla = Instantiate(projecticle, myPos.transform.position, myPos.transform.rotation);
                palle.Add(palla);
                numProiettili = numProiettili - 1;
                isAvaible = true;
                i++;
            }

            if (Input.GetKeyDown(KeyCode.Z) && isAvaible)
            {
                if (currentBaseState.nameHash == idleState)
                {
                    anim.SetBool("zKey", true);
                    
                    SimulateProjectile(palle[ i - 1]);
                    // palla.GetComponent<Rigidbody>().velocity = BallisticVel(myTarget, shootAngle);
                    // Destroy(ball, 10);

                    isAvaible = false;
                }
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
