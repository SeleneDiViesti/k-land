using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class salto_video1 : MonoBehaviour {
	public GameObject skip_fine_1;
	public Vector3 mposition;
	public Quaternion mrotation;
	public GameObject unitychain;
	public Vector3 scaleFactor = new Vector3(.3f, .3f, .3f);

	public VideoPlayer video;
	public VideoPlayer video_stop;

	void OnTriggerEnter(Collider other)
	{
		if (other.CompareTag ("Player")) {
			skip_fine_1 = GameObject.Find ("skip_fine_1");
			mposition = skip_fine_1.transform.position;
			mrotation = skip_fine_1.transform.rotation;
			unitychain = GameObject.FindGameObjectWithTag ("Player");

			video = GameObject.FindObjectOfType<VideoPlayer>();
			video_stop = GameObject.FindObjectOfType<VideoPlayer>();

			unitychain.transform.SetPositionAndRotation (mposition, mrotation);
			unitychain.transform.localScale = scaleFactor;

			video_stop.Stop ();
			video.Play();

		}
	}

}
