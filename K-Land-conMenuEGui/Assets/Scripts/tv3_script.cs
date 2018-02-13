using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tv3_script : MonoBehaviour {

    private Animator tv3;
    public GameObject Tv;
    // Use this for initialization
    void Start () {
        tv3 = Tv.GetComponent<Animator>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            tv3.Play("tv_animation");
        }
    }
    // Update is called once per frame
    void Update () {
		
	}
}
