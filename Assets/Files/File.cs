using UnityEngine;

[CreateAssetMenu(fileName = "New File", menuName = "Inventory/File")]
public class File : ScriptableObject
{
    new public string name = "New File";
    public string content = "";
    public int isSafe;
    //0-safe
    //1-sus
    //3-harmfull

    public virtual void Use()
    {
        Debug.Log("Using Software");
    }

}
