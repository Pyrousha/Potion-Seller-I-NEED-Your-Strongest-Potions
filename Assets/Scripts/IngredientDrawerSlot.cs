using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class IngredientDrawerSlot : DragAndDropSlot
{
    //public Dictionary<BaseColor, Color> colorMap = new Dictionary<BaseColor, Color>()
    //{
    //    {BaseColor.NONE, Color.white }, {BaseColor.RED, Color.red}, {BaseColor.YELLOW, Color.yellow},
    //    {BaseColor.GREEN, Color.green}, {BaseColor.BLUE, Color.blue}
    //};

    [SerializeField] private Ingredient slotIngredient;
    public override void OnDrop(PointerEventData eventData)
    {
        base.OnDrop(eventData);
        Debug.Log("Drop ingredient = " + slotIngredient.ToString());
        if (eventData.pointerDrag.GetComponent("Beaker") != null)
        {
            
            if (eventData.pointerDrag.GetComponent<Beaker>().ingredient1 == Ingredient.NONE)
                eventData.pointerDrag.GetComponent<Beaker>().ingredient1 = slotIngredient;
            else if (eventData.pointerDrag.GetComponent<Beaker>().ingredient2 == Ingredient.NONE)
                eventData.pointerDrag.GetComponent<Beaker>().ingredient2 = slotIngredient;
            //Color newColor;
            //colorMap.TryGetValue(slotColor, out newColor);
            //eventData.pointerDrag.GetComponentInChildren<Image>().color = newColor;
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
