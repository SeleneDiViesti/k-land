using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cannone3 : MonoBehaviour {
    public GameObject GuiCatapulta;
    public GameObject Cannone3;
    public GameObject CorpoCannone3;

    private bool isNear = false;
    private bool isAvaible = false;

    private int numProiettili;
    private int i = 0;
    public Animator anim3;
    public AnimatorStateInfo currentBaseState;

    static int idleState = Animator.StringToHash("Base Layer.New State3");
    static int animazione = Animator.StringToHash("Base Layer.cannone3_animation");

    public Transform myTarget;  // drag the target here
    public Transform myPos;
    public GameObject projecticle;  // drag the cannonball prefab here

    private List<GameObject> palle;

    //private float firingAngle = 45.0f;
    //private float gravity = 9.8f;
    private float t = 2f;
    // Use this for initialization
    void Start () {
        CorpoCannone3 = GameObject.Find("CorpoCannone3");
        //GuiCatapulta = GameObject.Find("GuiCatapulta");
        Cannone3 = GameObject.Find("Cannone3");
        GuiCatapulta.SetActive(false);
        anim3 = CorpoCannone3.GetComponent<Animator>();

        //numProiettili = int.Parse(stringa);
        numProiettili = 10;

        palle = new List<GameObject>();
        //StartCoroutine(SimulateProjectile());
        anim3.Play("New State3");
    }
    void SimulateProjectile(GameObject palla)
    {
        Vector3 forceDirection = myTarget.position - myPos.position;

        float X = forceDirection.x;         // Distance to travel along X : Space traveled @ time t
        float Y = forceDirection.y;         // Distance to travel along Y : Space traveled @ time t
        float Z = forceDirection.z;         // Distance to travel along Z : Space traveled @ time t

        float V0x = X / t;
        float V0z = Z / t;
        float V0y = (Y + (0.5f * Mathf.Abs(Physics.gravity.magnitude) * Mathf.Pow(t, 2))) / t;

        palla.GetComponent<Rigidbody>().AddForce(Vector3.right * 10f, ForceMode.VelocityChange);
        palla.GetComponent<Rigidbody>().AddForce(Vector3.up * V0y * 1.2f, ForceMode.VelocityChange);
    }
    // Update is called once per frame
    private void FixedUpdate()
    {
        currentBaseState = anim3.GetCurrentAnimatorStateInfo(0);
        if (isNear)
        {
            if (Input.GetKeyDown(KeyCode.C) && numProiettili > 0)
            {
                if (currentBaseState.nameHash == idleState)
                {
                    anim3.SetBool("cKey", true);
                }
                GameObject palla;
                //GameObject palla = Instantiate(projecticle, myPos.transform.position, myPos.transform.rotation, Catapulta.transform);
                palla = Instantiate(projecticle, myPos.transform.position, myPos.transform.rotation, Cannone3.transform);
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
                anim3.SetBool("cKey", false);
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
