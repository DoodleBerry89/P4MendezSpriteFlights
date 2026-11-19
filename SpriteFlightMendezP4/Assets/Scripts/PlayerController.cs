using UnityEngine.InputSystem;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public GameObject BoosterFlame;
    public float maxSpeed = 5f;
    public float thrustForce = 5f;
    Rigidbody2D rb;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Mouse.current.leftButton.isPressed) if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            BoosterFlame.SetActive(true);
        }
        else if (Mouse.current.leftButton.wasReleasedThisFrame)
        {
            BoosterFlame.SetActive(false);
        }
        if (Mouse.current.leftButton.isPressed)
        {

            // Calculalte mouse direction
            Vector3 mousePos = Camera.main.ScreenToWorldPoint(Mouse.current.position.value);
            Vector2 direction = (mousePos - transform.position).normalized;

            // Move player in the direction of mouse

            transform.up = direction;
            rb.AddForce(direction * thrustForce);

            if (rb.linearVelocity.magnitude > maxSpeed)
            {
                rb.linearVelocity = rb.linearVelocity.normalized * maxSpeed;
            }
        }



        void OnCollisionEnter2D(Collision2D collision)
        {
            Destroy(gameObject);
        }


    }

}