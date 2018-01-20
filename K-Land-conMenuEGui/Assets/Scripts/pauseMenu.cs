using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class pauseMenu : MonoBehaviour {

    public static bool GameIsPaused = false;
    public GameObject pauseUI;
    public GameObject playUI;

    void Start()
    {
        pauseUI = GameObject.Find("GuiPause");
        playUI = GameObject.Find("GuiPlay");
        pauseUI.SetActive(false);
    }


    // Update is called once per frame
    void Update () {
        if (Input.GetKeyDown(KeyCode.Escape)) //per mettere in pausa usiamo tasto esc
        {
            if (GameIsPaused)
            {
                Resume();
            } else
            {
                Pause();
            }
        }
	}

    public void Resume()
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

    public void QuitGame()
    {
        Application.Quit();
    }

    public void LoadMenu()
    {
        Time.timeScale = 1f;
        SceneManager.LoadScene("startMenu");
    }
   
}
