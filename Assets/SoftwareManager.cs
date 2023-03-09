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
        int slotIndex = (int)newSoftware.equipSlot;

        Software oldSoftware = null;

        if (currentSoftware[slotIndex] != null)
        {
            oldSoftware = currentSoftware[slotIndex];
            inventory.AddItem(oldSoftware);
        }

        if (onSoftwareChanged != null)
        {
            onSoftwareChanged.Invoke(newSoftware, oldSoftware);
        }

        currentSoftware[slotIndex] = newSoftware;
    }

}
