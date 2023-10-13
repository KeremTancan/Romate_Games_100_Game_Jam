using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AtaScript : MonoBehaviour
{
    public GameObject SaatiVerText;
    public GameObject Saat;
    private bool saatVerilebilir;

    
    void Start()
    {
        SaatiVerText.SetActive(false);
        Saat.SetActive(true);
        saatVerilebilir = false;
    }

    

    private void Update()
    {
        if (saatVerilebilir && Input.GetKeyDown(KeyCode.E))
        {
            Saat.SetActive(false);
            SaatiVerText.SetActive(false);          
            StartCoroutine(LoadSceneWithDelay(1.0f)); 
        }
    }

    private IEnumerator LoadSceneWithDelay(float delay)
    {
        yield return new WaitForSeconds(delay); 
        SceneManager.LoadScene(1); 
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SaatiVerText.SetActive(true);
            saatVerilebilir = true;
            
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            SaatiVerText.SetActive(false);
            saatVerilebilir = false;
        }
    }
}
