using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class introVideo : MonoBehaviour {

    public VideoPlayer video_intro;

    // Use this for initialization
    void Awake () {
        video_intro.GetComponent<VideoPlayer>();
        video_intro.Play();
    }
	
	// Update is called once per frame
	void Update () {
        //if (!video.isPlaying)
        if (!video_intro.isPlaying || Input.anyKey)
        {
            SceneManager.LoadScene("labirinto_scene");
        }
        //else
        //    Debug.Log("playing");
  	}
}
