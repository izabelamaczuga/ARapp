using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour {

    public void Start()
    {
        SetScreenOrientation();
    }

    public void SetScreenOrientation() {

        Screen.autorotateToLandscapeLeft = false;
        Screen.autorotateToLandscapeLeft = false;
        Screen.orientation = ScreenOrientation.Portrait;

    }

    public void Play ()
    {
        SceneManager.LoadScene("AR");
    }

    public void Menu()
    {
        SceneManager.LoadScene("menu");
    }

    public void QuitGame ()
    {
        Debug.Log("Close");
        Application.Quit();
    }

}
