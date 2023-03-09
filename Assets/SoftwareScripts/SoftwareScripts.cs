using UnityEngine;

[CreateAssetMenu(fileName = "New Item", menuName = "Inventory/Item")]
public class SoftwareScripts : ScriptableObject
{
    new public string name = "New SoftwarePart";
    public string description = "Piece of software";
    public Sprite icon = null;
    public bool isDefaultItem = false;

    public virtual void Use()
    {
        Debug.Log("Using Software");
    }

}
