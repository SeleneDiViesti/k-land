using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class salto_carte : MonoBehaviour {

	public GameObject salto_pos_carta;
    public Vector3 mposition;
	public Quaternion mrotation;
	public GameObject unitychain;
    public Vector3 scaleFactor = new Vector3(.3f, .3f, .3f);

	public VideoPlayer VideoPlayer_1;


    void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player")) {
			salto_pos_carta = GameObject.Find ("salto_pos_carta");
      		mposition = salto_pos_carta.transform.position;
			mrotation = salto_pos_carta.transform.rotation;
			unitychain = GameObject.FindGameObjectWithTag ("Player");

			VideoPlayer_1 = GameObject.FindObjectOfType<VideoPlayer>();

			unitychain.transform.SetPositionAndRotation (mposition, mrotation);
            unitychain.transform.localScale = scaleFactor;

			VideoPlayer_1.Play();

        }
	}



}
