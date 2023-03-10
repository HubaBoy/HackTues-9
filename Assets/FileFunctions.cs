using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FileFunctions : MonoBehaviour
{
    public Text Title;
    public Text Content;
    public GameObject FileInfo;
    public GameObject isSusImageGreen;
    public GameObject isSusImageYellow;
    public GameObject isSusImageRed;
    public bool isSus = false;

    public GameObject fileParent;

    public File file;

    void Update()
    {
        if(isSus == false)
        {
            isSusImageGreen.SetActive(true);
            isSusImageYellow.SetActive(false);
            isSusImageRed.SetActive(false);
        }else if(isSus == true)
        {
            isSusImageGreen.SetActive(false);
            isSusImageYellow.SetActive(true);
            isSusImageRed.SetActive(false);
        }
    }

    public void OnFileOpen()
    {
        FileInfo.SetActive(true);
        Title.text = file.name;
        Content.text = file.content;
    }

    public void ChekIfItIsSus()
    {
        if (isSus)
        {
            fileParent.GetComponent<FileParrent>().numberOfFoundFiles += 1;
            isSus = false;
        }
    }
}
