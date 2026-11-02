using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public float maxSpinSpeed = 10f;
    public float minSize = 0.5f;
    public float maxSize = 2.0f;
    Rigidbody2D rb;
    public float minspeed = 50f;
    public float maxspeed = 150f;
    float randomeTourqe = Random.Range(-maxSpinSpeed, maxSpinSpeed);
    rb.AddTorque(randomeTourqe);

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        float randomSize = Random.Range(minSize, maxSize);
        transform.localScale = new Vector3(randomSize, randomSize, 1);

        rb = GetComponent<Rigidbody2D>();

        Vector2 randomDirection = Random.insideUnitCircle;

        float randomSpeed = Random.Range(minSpeed, maxSpeed) / randomSize;


        float randomTorque = Random.Range(-maxSpinSpeed, maxSpinSpeed);
        rb.AddTorque(randomTorque);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
