using UnityEngine;

public class ItemPickUp : Interactable
{
    public Software software;

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
        Debug.Log("Picking up " + software.name);
        bool wasPickedUp = Inventory.instance.AddItem(software);
        if(wasPickedUp)
        {
            Destroy(gameObject);
        }

    }
}