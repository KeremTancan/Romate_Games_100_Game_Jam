using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PressE : MonoBehaviour
{
    public GameObject CreditsPanel;
    int sceneIndex = 10;
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            

           if(sceneIndex < 0)
            {
                Debug.Log("Oyundan çýkýldý");
                Application.Quit();
                
            }
            else
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                sceneIndex--;
            }
                
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
