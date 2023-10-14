using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.ReorderableList.Element_Adder_Menu;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BirdController : MonoBehaviour
{
    public float flapForce = 5f;    
    public float maxVerticalSpeed = 5f;  
    public float gravity = 9.8f;    

    private Rigidbody2D rb;

    private int mermiHit =0;

    private SpriteRenderer spriteRenderer;
    private Color defaultColor;

    

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        spriteRenderer = GetComponent<SpriteRenderer>();
        defaultColor = spriteRenderer.color;
    }

    private void Update()
    {
        
        if (Input.GetKey(KeyCode.W))
        {
            Flap();
        }

      
        Vector2 velocity = rb.velocity;
        velocity.y = Mathf.Clamp(velocity.y, -maxVerticalSpeed, maxVerticalSpeed);
        rb.velocity = velocity;

       
        rb.AddForce(Vector2.down * gravity);

        if(mermiHit == 3)
        {
            Debug.Log("Oyun Bitti");
        }
    }

    private void Flap()
    {
       
        rb.AddForce(Vector2.up * flapForce, ForceMode2D.Impulse);
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Mermi"))
        {
            Destroy(collision.gameObject);
            mermiHit++;
            spriteRenderer.color = Color.red;

            GameObject gameObjectToHide = GameObject.Find("Kalp");
            gameObjectToHide.SetActive(false);



            // Start a coroutine to revert the color back to the default after a delay
            StartCoroutine(RevertColorAfterDelay(1.0f));

        }

        if (collision.gameObject.CompareTag("Komutan"))
        {
            SceneManager.LoadScene(2);
        }

    }

    private IEnumerator RevertColorAfterDelay(float delay)
    {
        yield return new WaitForSeconds(delay);

        // Revert the color to the default color
        spriteRenderer.color = defaultColor;
    }
}
