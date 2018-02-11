using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class introVideo : MonoBehaviour {

    public VideoPlayer video;

    // Use this for initialization
    void Awake () {
        video.GetComponent<VideoPlayer>();
        video.Play();
    }
	
	// Update is called once per frame
	void Update () {
        //if (!video.isPlaying)
        if (!video.isPlaying || Input.anyKey)
        {
            SceneManager.LoadScene("labirinto_scene");
        }
        //else
        //    Debug.Log("playing");
  	}
}
