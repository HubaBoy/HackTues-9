using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NavBar : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ActivateSubSite(string name)
    {
        foreach(Transform children in transform)
        {
            if(children.name == name)
            {
                children.gameObject.SetActive(true);
            }
            else if(children.name != name && children.name != "NavBar")
            {
                children.gameObject.SetActive(false);
            }
        }
    }
}
