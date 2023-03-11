using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

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

    }

    public void OnFileOpen()
    {
        FileInfo.SetActive(true);
        FileInfo.GetComponent<FileDisplayer>().fileOpened = transform;
        Title.text = file.name;
        Content.text = file.content;
    }

    public void ChekIfItIsSus()
    {
        if (isSus == false)
        {
            isSusImageGreen.SetActive(true);
            isSusImageYellow.SetActive(false);
            isSusImageRed.SetActive(false);
        }
        else if (isSus == true)
        {
            isSusImageGreen.SetActive(false);
            isSusImageYellow.SetActive(false);
            isSusImageRed.SetActive(true);
        }
    }

    public void LoadPresentation()
    {
        SceneManager.LoadScene("Presentation");
    }
}
