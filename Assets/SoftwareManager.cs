using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoftwareManager : MonoBehaviour
{
    #region Singleton

    public static SoftwareManager instance;

    void Awake()
    {
        instance = this;
    }

    #endregion

    Software[] currentSoftware;

    public delegate void OnSoftwareChanged(Software newSoftware, Software oldSoftware);
    public OnSoftwareChanged onSoftwareChanged;

    Inventory inventory;

    void Start()
    {
        inventory = Inventory.instance;
        int numSlots = System.Enum.GetNames(typeof(SoftwareSlot)).Length;
        currentSoftware = new Software[numSlots];
    }

    public void Equip(Software newSoftware)
    {
        Debug.Log("1");
        int slotIndex = (int)newSoftware.equipSlot;
        Debug.Log("2");
        Software oldSoftware = null;
        Debug.Log("3");

        Debug.Log("current software" + currentSoftware[slotIndex]);

        if (currentSoftware[slotIndex] != null)
        {
            Debug.Log("4");
            oldSoftware = currentSoftware[slotIndex];
            Debug.Log("5");
            inventory.AddItem(oldSoftware);
            Debug.Log("6");
        }

        if (onSoftwareChanged != null)
        {
            Debug.Log("7");
            onSoftwareChanged.Invoke(newSoftware, oldSoftware);
            Debug.Log("8");
        }
        Debug.Log("9");

        currentSoftware[slotIndex] = newSoftware;
        Debug.Log("10");
    }

}
