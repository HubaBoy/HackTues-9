using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InfoShowup : MonoBehaviour
{
    public Software software;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Equiping()
    {
        SoftwareManager.instance.Equip(software);
    }
}
