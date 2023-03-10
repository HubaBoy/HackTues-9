using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FileFunctions : MonoBehaviour
{
    public Text Title;
    public Text Content;
    public GameObject FileInfo;

    public File file;

    public void OnFileOpen()
    {
        FileInfo.SetActive(true);
        Title.text = file.name;
        Content.text = file.content;
    }
}
