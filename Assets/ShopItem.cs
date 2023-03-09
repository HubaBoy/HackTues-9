using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShopItem : MonoBehaviour
{
    public GameObject infoShowup;
    public InfoShowup InfoShowup;
    public Software software;

    public void OnButtonPress()
    {
        infoShowup.SetActive(true);
        infoShowup.transform.position = transform.position;
        InfoShowup.software = software;
        InfoShowup.name = software.name;
        InfoShowup.description = software.description;
    }
}
