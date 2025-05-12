using UnityEngine;

[RequireComponent(typeof(TrailRenderer))]
[RequireComponent(typeof(Rigidbody2D))]
public class ParticleController : MonoBehaviour
{
    public Vector2 velocity = new Vector2(1, 0);
    private Rigidbody2D rb;
    private TrailRenderer trailRenderer;
    public float m_timeToLive = 5;
    private float m_timeToLiveDelta = 5;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        trailRenderer = GetComponent<TrailRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        m_timeToLive -= Time.deltaTime;
        if (m_timeToLive < 0)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnEnable()
    {
        m_timeToLiveDelta = m_timeToLive;
        rb.linearVelocity = velocity;
        trailRenderer.Clear();
    }

    public void ResetTrail()
    {
         trailRenderer.Clear();
    }
}
