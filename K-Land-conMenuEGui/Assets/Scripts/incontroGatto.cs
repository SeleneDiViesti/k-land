using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class incontroGatto : MonoBehaviour {

	public GameObject spostamento_2_finegatto;
	public Vector3 mposition;
	public Quaternion mrotation;
	public GameObject unitychain;

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player")) {
			spostamento_2_finegatto = GameObject.Find ("spostamento_2_finegatto");
			mposition = spostamento_2_finegatto.transform.position;
			mrotation = spostamento_2_finegatto.transform.rotation;
			unitychain = GameObject.FindGameObjectWithTag ("Player");

			unitychain.transform.SetPositionAndRotation (mposition, mrotation);

			// premere p per avviare animazioni
		}
	}


}
