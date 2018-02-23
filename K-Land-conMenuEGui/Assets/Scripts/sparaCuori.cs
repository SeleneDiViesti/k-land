using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sparaCuori : MonoBehaviour {

    public GameObject GuiBacchetta;
    public GameObject bacchetta;
    private bool isNear = false;
    private int numProiettili;
    public GameObject ColliderInfoCuffie;

    public Transform myTarget;  // drag the target here
    public Transform myPos;
    public GameObject cuore;

    public AudioSource sparo;

    private float t = 2f;

    
    // Use this for initialization
    void Start () {
		
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

        cuore.GetComponent<Rigidbody>().AddForce(Vector3.forward * 5f, ForceMode.VelocityChange);
        cuore.GetComponent<Rigidbody>().AddForce(Vector3.up * V0y * 1.2f, ForceMode.VelocityChange);
        sparo.Play();
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GuiBacchetta.SetActive(true);
            isNear = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GuiBacchetta.SetActive(false);
            isNear = false;
        }
    }
    // Update is called once per frame
    private void Update()
    {
        if (isNear)
        {
           
            numProiettili = ColliderInfoCuffie.GetComponent<infoCuffie>().GetCuffie();
            if (Input.GetKeyDown(KeyCode.X) && numProiettili>0)
             
            {
                GameObject heart = Instantiate(cuore, myPos.transform.position, myPos.transform.rotation, bacchetta.transform);
                
                SimulateProjectile(heart);
                ColliderInfoCuffie.GetComponent<infoCuffie>().updateCuffie(-1);
               
            }
        }
    }
}
