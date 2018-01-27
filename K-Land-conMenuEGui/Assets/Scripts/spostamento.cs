using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spostamento : MonoBehaviour {


	public GameObject skip;
	public Vector3 mposition;
	public Quaternion mrotation;
	public GameObject unitychain;


	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player")) {
			skip = GameObject.Find ("skip");
			mposition = skip.transform.position;
			mrotation = skip.transform.rotation;
			unitychain = GameObject.FindGameObjectWithTag ("Player");

			unitychain.transform.SetPositionAndRotation (mposition, mrotation);


		}
	}


}
