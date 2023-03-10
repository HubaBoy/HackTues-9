using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment", menuName = "Inventory/Equipment")]
public class Software : SoftwareScripts
{
    public SoftwareSlot equipSlot;

    public float DetectionSoftwarePower;
    public float AntiMalwareSoftwarePower;
    public float AntiSQLSoftwarePower;
    public float BandwithPower;
    public float FireWallPower;

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

public enum SoftwareSlot { slot1, slot2, slot3, slot4, slot5 }