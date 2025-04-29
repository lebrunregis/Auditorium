using UnityEngine;
using UnityEngine.EventSystems;

[RequireComponent(typeof(RectTransform))]
public class DragAndDrop : MonoBehaviour, IDragHandler,IBeginDragHandler,IEndDragHandler
{
    private RectTransform rectTransform;
    public Material material;
    public Color draggedColor = Color.green;
    public Color droppedColor = Color.red;

    public void OnBeginDrag(PointerEventData eventData)
    {
        material.color = draggedColor;
    }

    public void OnDrag(PointerEventData eventData)
    {
        rectTransform.anchoredPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        material.color = droppedColor;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        rectTransform = GetComponent<RectTransform>();
    }
}
