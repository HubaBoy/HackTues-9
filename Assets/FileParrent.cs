using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileParrent : MonoBehaviour
{
    public static FileParrent instance;

    public bool isBeingHacked = false;
    public int numberOfCoruptedFiles = 0;
    public int numberOfFoundFiles = 0;

    // Update is called once per frame
    void Update()
    {
        
    }
}
