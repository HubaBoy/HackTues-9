using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/Equipment")]
public class Software : SoftwareScripts
{
    public SoftwareSlot equipSlot;

    public int modifier1;
    public int modifier2;

    public override void Use()
    {
        base.Use();
        SoftwareManager.instance.Equip(this);
        RemoveFromInventory();
    }

    public void RemoveFromInventory()
    {
        Inventory.instance.RemoveItem(this);
    }
}

public enum SoftwareSlot { slot1, slot2, slot3, slot4 }