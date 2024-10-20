using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class DragAndDropSlot : MonoBehaviour, IDropHandler
{
    [SerializeField] private bool acceptsBeaker;
    [SerializeField] private bool canPlaceBeakerHere;
    public virtual void OnDrop(PointerEventData eventData)
    {
        Debug.Log("OnDrop " + (eventData.pointerDrag.GetComponent("Beaker") != null));
        if (canPlaceBeakerHere && eventData.pointerDrag.GetComponent("Beaker") != null)
        {
            Debug.Log("Can Place");
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = GetComponent<RectTransform>().localPosition;
        }
        else
        {
            Debug.Log("Can't Place");
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = eventData.pointerDrag.GetComponent<DragAndDropItem>().startPos;
        }
    }

    public void AlterBeaker()
    {
        // let extension classes hide this
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
