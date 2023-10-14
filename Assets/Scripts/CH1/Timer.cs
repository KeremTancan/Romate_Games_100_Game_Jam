using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour
{
   
    public TextMeshProUGUI timerText;
    public float timer = 10;
    

    void Start()
    {
        timerText.text = "0";
    }

    
    void Update()
    {
        
        timer -= Time.deltaTime;
        timerText.text = timer.ToString("F0");


        if (timer <= 0)
        {
            SceneManager.LoadScene(sceneBuildIndex: 0);
        }
        if (timer < 5)
        {
            timerText.color= Color.red;
        }
    }
}
