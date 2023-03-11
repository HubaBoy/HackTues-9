using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlideSwicher : MonoBehaviour
{
    public GameObject nextSlide;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            nextSlide.SetActive(true);
            gameObject.SetActive(false);
        }
    }
}
