using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FileDisplayer : MonoBehaviour
{
    public void OnCloseButton()
    {
        transform.gameObject.SetActive(false);
    }
}
