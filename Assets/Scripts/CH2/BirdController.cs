using UnityEngine;

public class BirdController : MonoBehaviour
{
    public float flapForce = 5f;    
    public float maxVerticalSpeed = 5f;  
    public float gravity = 9.8f;    

    private Rigidbody2D rb;

    private int mermiHit =0;

    private void Start()
    {
        rb = GetComponent<Rigidbody2D>();
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

        if(mermiHit == 4)
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
        }
    }
}
