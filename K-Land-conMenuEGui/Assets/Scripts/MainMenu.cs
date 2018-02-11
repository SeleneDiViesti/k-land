using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

  
    public void PlayGame()
    {
        // SceneManager.LoadScene("labirinto_scene");
        SceneManager.LoadScene("videoIntro_scene");
    }
    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
   
    
}
