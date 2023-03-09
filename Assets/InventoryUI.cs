using UnityEngine;

public class InventoryUI : MonoBehaviour
{

    public Transform itemParent;

    Inventory inventory;

    InventorySlot[] slots;

    void Start()
    {
        inventory = Inventory.instance;
        inventory.onItemChangedCallback += UpdateUI;

        slots = itemParent.GetComponentsInChildren<InventorySlot>();
        UpdateUI();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void UpdateUI()
    {
        for (int i = 0; i < slots.Length; i++)
        {
            if (i < inventory.items.Count)
            {
                slots[i].AddItem(inventory.items[i]);
            }
            else
            {
                slots[i].ClearSlot();
            }
        }
    }
}