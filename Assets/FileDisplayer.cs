using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileDisplayer : MonoBehaviour
{
    public Transform fileOpened;

    public void OnCloseButton()
    {
        transform.gameObject.SetActive(false);
    }

    public void DeleteFile()
    {
        fileOpened.parent.GetComponent<FileParrent>().numberOfFoundFiles += 1;
        Destroy(fileOpened.gameObject);
    }
}
