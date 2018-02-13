using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public GameObject video;
    public GameObject mainmenu;

    public void PlayGame()
    {
        // SceneManager.LoadScene("labirinto_scene");
        //SceneManager.LoadScene("videoIntro_scene");
        video.SetActive(true);
        mainmenu.SetActive(false);
    }

    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
   
}
