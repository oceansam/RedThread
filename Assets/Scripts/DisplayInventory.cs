using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DisplayInventory : MonoBehaviour
{
    public InventoryObject inventory;
    public int width;
    public int height;
    public int slot_Numbers;
    Dictionary<InventorySlot, GameObject> itemsDisplayed = new Dictionary<InventorySlot, GameObject>();
    // Start is called before the first frame update
    void Start()
    {
        createDisplay();
    }

    // Update is called once per frame
    void Update()
    {
      //  updateDisplay();
    }

    public void createDisplay(){
        
        for (int i = 0; i < inventory.Container.Count;i++){
            var temp = inventory.Container[i].item.prefab;
            var item = Instantiate(temp, Vector3.zero, Quaternion.identity, transform);
            item.GetComponent<RectTransform>().localPosition = getPosition(i);
        }
    }

    public Vector3 getPosition(int pos){

        return new Vector3(width * (pos % slot_Numbers) - 180, 1f, 0f);
    }
}
