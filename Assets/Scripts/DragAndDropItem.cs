using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDropItem : MonoBehaviour, IPointerDownHandler, IBeginDragHandler, IEndDragHandler, IDragHandler
{
    [SerializeField] private Canvas canvas;
    [SerializeField] private float staticAlpha;
    [SerializeField] private float draggingAlpha;

    private RectTransform rectTransform;
    private CanvasGroup canvasGroup;
    public Vector2 startPos;
    private void Awake()
    {
        //canvas = GetComponent<Canvas>();
        rectTransform = GetComponent<RectTransform>();
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("BeginDrag");
        canvasGroup.alpha = draggingAlpha;
        canvasGroup.blocksRaycasts = false;
        startPos = rectTransform.anchoredPosition;
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Drag");
        rectTransform.anchoredPosition += eventData.delta / canvas.scaleFactor;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        Debug.Log("EndDrag");
        canvasGroup.alpha = staticAlpha;
        canvasGroup.blocksRaycasts = true;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        Debug.Log("PointerDown");
    }
}
