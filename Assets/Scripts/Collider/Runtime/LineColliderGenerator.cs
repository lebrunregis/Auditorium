using UnityEngine;

[RequireComponent(typeof(MeshCollider))]
[RequireComponent(typeof(LineRenderer))]
[RequireComponent(typeof(MeshFilter))]
public class LineColliderGenerator : MonoBehaviour
{
    private MeshCollider mesh;
    private MeshFilter meshFilter;
    private LineRenderer lineRenderer;
    private Mesh lineMesh;
    public bool bakeInWorldSpace = false;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private void Start()
    {
        lineMesh = GetComponent<Mesh>();
        lineRenderer = GetComponent<LineRenderer>();
        mesh = GetComponent<MeshCollider>();

        mesh.sharedMesh = lineMesh;
    }

    // Update is called once per frame
    private void Update()
    {
     Mesh bakedMesh = new Mesh();
        lineRenderer.BakeMesh(lineMesh, false);
   
        // Optionally, you can create a new MeshFilter and MeshRenderer if you want to
        // display the baked mesh as a separate object
        // MeshFilter meshFilter = gameObject.AddComponent<MeshFilter>();
        // MeshRenderer meshRenderer = gameObject.AddComponent<MeshRenderer>();
        // meshFilter.mesh = bakedMesh;

     //   lineRenderer.BakeMesh(bakedMesh,);

        // If you want to add a collider, you can do it here
        // MeshCollider meshCollider = gameObject.AddComponent<MeshCollider>();
        // meshCollider.sharedMesh = bakedMesh;

        // If you want to visualize the baked mesh, assign it to a MeshFilter
        meshFilter.mesh = bakedMesh;
    }
}
