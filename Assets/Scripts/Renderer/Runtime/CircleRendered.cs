using UnityEngine;

public class CircleRendered : MonoBehaviour
{
    public LineRenderer lineRenderer;
    public int steps = 90;
    public float radius = 1f;
    public Color color = Color.white;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        DrawCircle(steps, radius);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void DrawCircle(int steps, float radius)
    {
        lineRenderer.positionCount = steps;

        for (int i = 0; i < steps; i++)
        {
            float progress = (float)i / steps;

            float radians = progress * Mathf.PI;

            float x = Mathf.Cos(radians);
            float y = Mathf.Sin(radians);

            float xScaled = x * radius;
            float yScaled = y * radius;

            Vector2 pos = new Vector2(xScaled, yScaled);

            lineRenderer.SetPosition(i, pos);
        }
    }
}
