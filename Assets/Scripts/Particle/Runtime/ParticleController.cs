using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ParticleController : MonoBehaviour
{
    public Vector2 velocity;
    private Rigidbody2D rb;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = velocity;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
