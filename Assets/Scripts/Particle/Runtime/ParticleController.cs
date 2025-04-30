using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class ParticleController : MonoBehaviour
{
    public Vector2 velocity;
    private Rigidbody2D rb;
    public float ttl = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        rb.linearVelocity = velocity;
    }

    // Update is called once per frame
    void Update()
    {
        ttl -= Time.deltaTime;
        if(ttl < 0)
        {
            gameObject.SetActive(false);
        }
    }
}
