using Tools;
using UnityEngine;

[RequireComponent(typeof(CircleRenderer))]
[RequireComponent (typeof(CircleRenderer))]
[RequireComponent (typeof(GameObjectPool))]
public class SpawnerController : MonoBehaviour
{
    public Vector2 particleVelocity;
    private Tools.GameObjectPool particlePool;
    public float spawnTime = 0.1f;
    private float spawnRange;
    private float spawnDelta;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        spawnRange = GetComponent<CircleRenderer>().radius;
        particlePool = GetComponent<GameObjectPool>();
    }

    // Update is called once per frame
    void Update()
    { 
        spawnDelta -= spawnDelta *Time.deltaTime;
        if(spawnDelta < 0)
        {
            spawnDelta = spawnTime;
            GameObject particle = particlePool.GetFistAvailableObject();
            if (particle != null)
            {
                particle.transform.position = transform.position;
                particle.SetActive(true);
                //particle
            }
        }
    }
}
