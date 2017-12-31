using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour {

    public static bool New=false;
    public static bool Load=false;

    public void PlayGame()
    {
        New = true;
        Load = false;
        //TODO SceneManager.LoadScene("level0")
    }
    public void QuitGame()
    {
        Debug.Log("quit");
        Application.Quit();
    }
    public void LoadGame()
    {
        New = false;
        Load = true;
        //TODO 
       // Application.LoadLevel(PlayerPrefs.GetInt("currentscenesave"));
    }
    
}
