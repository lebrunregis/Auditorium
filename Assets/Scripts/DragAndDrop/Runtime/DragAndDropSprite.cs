using UnityEngine;

[RequireComponent (typeof(SpriteRenderer))]
public class DragAndDropSprite : MonoBehaviour
{
    public Color draggedColor = Color.green;
    public Color droppedColor = Color.red;
    public Camera cam;
    public SpriteRenderer spriteRenderer;

    public void OnMouseDown()
    {
        Debug.Log("Drag");
        spriteRenderer.color = draggedColor;
    }

    public void OnMouseUp()
    {
        Debug.Log("Drop");
        spriteRenderer.color = droppedColor;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cam = Camera.main;
        spriteRenderer = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void OnMouseDrag()
    {
            Vector3 mousePos = Input.mousePosition;
            mousePos.z = cam.nearClipPlane;
            Vector3 newPos  = cam.ScreenToWorldPoint(mousePos);
            newPos.z = 0;
            transform.parent.position = newPos;
    }
}
