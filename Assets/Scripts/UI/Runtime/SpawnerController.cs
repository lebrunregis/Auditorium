using UnityEngine;

[RequireComponent (typeof(CircleRenderer))]
public class SpawnerController : MonoBehaviour
{
    public Vector2 particleVelocity;
    public GameObject particle;
    public float spawnTime;
    private float spawnRange;
    private float spawnDelta;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnRange = GetComponent<CircleRenderer>().radius;
    }

    // Update is called once per frame
    void Update()
    {
        if(spawnDelta < 0)
        {
            spawnDelta = spawnTime;

        } else
        {
            spawnDelta -= spawnDelta *Time.deltaTime;
        }
    }
}
