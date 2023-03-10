using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileParrent : MonoBehaviour
{
    public static FileParrent instance;

    public bool isBeingHacked = false;
    public int numberOfCoruptedFiles = 0;
    public int numberOfFoundFiles = 0;
    public GameObject warningSign;

    // Update is called once per frame
    void Update()
    {
        if(numberOfCoruptedFiles > 0 && numberOfFoundFiles == numberOfCoruptedFiles)
        {
            SuccessfullyDefended();
        }
    }

    public void SuccessfullyDefended()
    {
        warningSign = GameObject.Find("CyberAttack");
        warningSign.GetComponent<SyberAttack>().isUnderCyberAttack = false;
    }
}
 