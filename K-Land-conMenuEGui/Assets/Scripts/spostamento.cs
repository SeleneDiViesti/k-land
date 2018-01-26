using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spostamento : MonoBehaviour {


	public GameObject spostamento_2;
	public Vector3 mposition;
	public Quaternion mrotation;
	public GameObject unitychain;


	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player")) {
			spostamento_2 = GameObject.Find ("spostamento_2");
			mposition = spostamento_2.transform.position;
			mrotation = spostamento_2.transform.rotation;
			unitychain = GameObject.FindGameObjectWithTag ("Player");

			unitychain.transform.SetPositionAndRotation (mposition, mrotation);


		}
	}


}
