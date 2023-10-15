using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressE : MonoBehaviour
{
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void StartButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void CreditsButton()
    {
        GameObject gameObjectToShow = GameObject.Find("CreditsPanel");
        gameObjectToShow.SetActive(true);
    }

    public void CreditsBackButton()
    {
        GameObject gameObjectToShow = GameObject.Find("CreditsPanel");
        gameObjectToShow.SetActive(false);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
