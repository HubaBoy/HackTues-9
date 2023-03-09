using UnityEngine;

public class ItemPickUp : Interactable
{
    public SoftwareScripts SoftwareScript;

    public override void Interact ()
    {
        base.Interact ();
        Debug.Log("Interacting");
        float distance = Vector2.Distance(player.position, transform.position);
        if (distance <= radius)
        {
            PickUp();
        }
    }

    void PickUp()
    {
        Debug.Log("Picking up " + SoftwareScript.name);
        bool wasPickedUp = Inventory.instance.AddItem(SoftwareScript);
        if(wasPickedUp)
        {
            Destroy(gameObject);
        }

    }
}