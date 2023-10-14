using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float scrollSpeed = 1.0f;  

    private Transform backgroundTransform;
    private Vector3 initialPosition;

    private void Start()
    {
        
        backgroundTransform = transform;
        initialPosition = backgroundTransform.position;
    }

    private void Update()
    {
        
        Vector3 newPosition = backgroundTransform.position - new Vector3(scrollSpeed * Time.deltaTime, 0, 0);
        backgroundTransform.position = newPosition;

        
        if (backgroundTransform.position.x <= -15.0f)  
        {
            backgroundTransform.position = initialPosition;
        }
    }
}
