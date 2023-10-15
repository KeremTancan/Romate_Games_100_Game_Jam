using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject EvetSprite;
    public GameObject Hay�rSprite;

    private int say� =  0;

    void Start()
    {
        Hay�rSprite.SetActive(true);
        EvetSprite.SetActive(false);
    }

    

    public void EvetTik()
    {
        GameObject gameObjectToHide = GameObject.Find("");
        Hay�rSprite.SetActive(false);
        EvetSprite.SetActive(true);
        

        switch (say�)
        {
            case 0: gameObjectToHide = GameObject.Find("Hilafet");
                Destroy(gameObjectToHide, 1);
                say�++;
                break;
            case 1:
                gameObjectToHide = GameObject.Find("Soyad�");
                Destroy(gameObjectToHide, 1);
                say�++;
                break;
            case 2:
                gameObjectToHide = GameObject.Find("Se�ilme");
                Destroy(gameObjectToHide, 1);
                say�++;
                break;
            case 3:
                gameObjectToHide = GameObject.Find("Yunanistan");
                Destroy(gameObjectToHide, 1);
                say�++;
                break;

        }

        if (gameObjectToHide == null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }


    }

    public void HayirTik()
    {
        GameObject gameObjectToHide = GameObject.Find("");
        Hay�rSprite.SetActive(true);
        EvetSprite.SetActive(false);
        

        switch (say�)
        {
            case 0:
                gameObjectToHide = GameObject.Find("Hilafet");
                Destroy(gameObjectToHide, 1);
                say�++;
                break;
            case 1:
                gameObjectToHide = GameObject.Find("Soyad�");
                Destroy(gameObjectToHide, 1);
                say�++;
                break;
            case 2:
                gameObjectToHide = GameObject.Find("Se�ilme");
                Destroy(gameObjectToHide, 1);
                say�++;
                break;
            case 3:
                gameObjectToHide = GameObject.Find("Yunanistan");
                Destroy(gameObjectToHide, 1);
                say�++;
                break;

        }

        if (gameObjectToHide == null)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
