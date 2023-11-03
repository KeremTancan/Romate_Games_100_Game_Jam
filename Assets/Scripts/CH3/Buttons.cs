using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Buttons : MonoBehaviour
{
    public GameObject EvetSprite;
    public GameObject HayýrSprite;

    private int sayý =  0;

    void Start()
    {
        HayýrSprite.SetActive(true);
        EvetSprite.SetActive(false);
    }

    public void EvetTik()
    {
        GameObject gameObjectToHide = GameObject.Find("");
        HayýrSprite.SetActive(false);
        EvetSprite.SetActive(true);
        

        switch (sayý)
        {
            case 0: gameObjectToHide = GameObject.Find("Hilafet");
                Destroy(gameObjectToHide, 1);
                sayý++;
                break;
            case 1:
                gameObjectToHide = GameObject.Find("Soyadý");
                Destroy(gameObjectToHide, 1);
                sayý++;
                break;
            case 2:
                gameObjectToHide = GameObject.Find("Seçilme");
                Destroy(gameObjectToHide, 1);
                sayý++;
                break;
            case 3:
                gameObjectToHide = GameObject.Find("Yunanistan");
                Destroy(gameObjectToHide, 1);
                StartCoroutine(DeleyCode(1));
                break;

        }
    }

    public void HayirTik()
    {
        GameObject gameObjectToHide = GameObject.Find("");
        HayýrSprite.SetActive(true);
        EvetSprite.SetActive(false);
        

        switch (sayý)
        {
            case 0:
                gameObjectToHide = GameObject.Find("Hilafet");
                Destroy(gameObjectToHide, 1);
                sayý++;
                break;
            case 1:
                gameObjectToHide = GameObject.Find("Soyadý");
                Destroy(gameObjectToHide, 1);
                sayý++;
                break;
            case 2:
                gameObjectToHide = GameObject.Find("Seçilme");
                Destroy(gameObjectToHide, 1);
                sayý++;
                break;
            case 3:
                gameObjectToHide = GameObject.Find("Yunanistan");
                Destroy(gameObjectToHide, 1);
                StartCoroutine(DeleyCode(1));
                sayý++;
                break;

        }
    }



    private IEnumerator DeleyCode(float delay)
    {
        yield return new WaitForSeconds(delay);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
