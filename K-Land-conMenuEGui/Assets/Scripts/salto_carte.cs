using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class salto_carte : MonoBehaviour {

	public GameObject salto_pos_carta;
    public Vector3 mposition;
	public Quaternion mrotation;
	public GameObject unitychain;

	

	
	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player")) {
			salto_pos_carta = GameObject.Find ("salto_pos_carta");
      		mposition = salto_pos_carta.transform.position;
			mrotation = salto_pos_carta.transform.rotation;
			unitychain = GameObject.FindGameObjectWithTag ("Player");

			unitychain.transform.SetPositionAndRotation (mposition, mrotation);

			
		}
	}

}
