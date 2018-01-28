using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class salto_video2 : MonoBehaviour {
	public GameObject skip_fine_2;
	public Vector3 mposition;
	public Quaternion mrotation;
	public GameObject unitychain;
	public Vector3 scaleFactor = new Vector3(.3f, .3f, .3f);


	public VideoPlayer VideoPlayer_3;

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player")) {
			skip_fine_2 = GameObject.Find ("skip_fine_2");
			mposition = skip_fine_2.transform.position;
			mrotation = skip_fine_2.transform.rotation;
			unitychain = GameObject.FindGameObjectWithTag ("Player");

			VideoPlayer_3 = GameObject.FindObjectOfType<VideoPlayer>();

			unitychain.transform.SetPositionAndRotation (mposition, mrotation);
			unitychain.transform.localScale = scaleFactor;

			VideoPlayer_3.Stop ();


		}
	}
}
