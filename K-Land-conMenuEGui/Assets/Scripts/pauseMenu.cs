using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;
    public GameObject pauseUI;
    public GameObject playUI;
    public GameObject vuoiUscire;

    void Start()
    {
       // pauseUI = GameObject.Find("GuiPause");
       // playUI = GameObject.Find("GuiPlay");
       // pauseUI.SetActive(false);
    }


    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)) //per mettere in pausa usiamo tasto esc
        {
            if (GameIsPaused)
            {
                Resume();
            }
            else
            {
                Pause();
            }
        }
	}

    void Resume()
    {
        pauseUI.SetActive(false);
        playUI.SetActive(true);
        Time.timeScale = 1f;
        GameIsPaused = false;
    }

    void Pause()
    {
        pauseUI.SetActive(true);
        playUI.SetActive(false);
        Time.timeScale = 0f;
        GameIsPaused = true;
    }

    public void Exit()
    {
        vuoiUscire.SetActive(true);
    }

    void NoButtonPressed()
    {
        vuoiUscire.SetActive(false);
    }

    void QuitGame()
    {
        Debug.Log("uscito");
        Application.Quit();
    }

    
    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("startMenu");
    }
   
}
