using System.Collections;
using UnityEngine;

public class EnableGameObjectsOneByOne : MonoBehaviour
{
    public GameObject[] gameObjectsToEnable;
    private int currentIndex = 0;

    private void Start()
    {
        // Start the coroutine to enable game objects one by one
        StartCoroutine(EnableGameObjects());
    }

    IEnumerator EnableGameObjects()
    {
        while (currentIndex < gameObjectsToEnable.Length)
        {
            gameObjectsToEnable[currentIndex].SetActive(true);
            currentIndex++;

            yield return new WaitForSeconds(5.0f);
        }
    }
}
