using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressE : MonoBehaviour
{
    public GameObject CreditsPanel;
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
        CreditsPanel.SetActive(true);
    }

    public void CreditsBackButton()
    {
        CreditsPanel.SetActive(false);
    }

    public void ExitButton()
    {
        Application.Quit();
    }
}
