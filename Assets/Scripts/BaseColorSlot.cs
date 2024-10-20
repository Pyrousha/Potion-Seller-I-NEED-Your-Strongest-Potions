using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class BaseColorSlot : DragAndDropSlot
{
    public Dictionary<BaseColor, Color> colorMap = new Dictionary<BaseColor, Color>()
    {
        {BaseColor.NONE, Color.white }, {BaseColor.RED, Color.red}, {BaseColor.YELLOW, Color.yellow},
        {BaseColor.GREEN, Color.green}, {BaseColor.BLUE, Color.blue}
    };

    [SerializeField] private BaseColor slotColor;
    public override void OnDrop(PointerEventData eventData)
    {
        base.OnDrop(eventData);
        Debug.Log("Drop color = " + slotColor.ToString());
        if (eventData.pointerDrag.GetComponent("Beaker") != null)
        {
            eventData.pointerDrag.GetComponent<Beaker>().color = slotColor;
            Color newColor;
            colorMap.TryGetValue(slotColor, out newColor);
            eventData.pointerDrag.GetComponentInChildren<Image>().color = newColor;
        }
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
