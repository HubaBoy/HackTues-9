using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OpenPC : Interactable
{
    public SceneController sceneController;

    public override void Interact()
    {
        base.Interact();

        sceneController.LoadScene("suuu");
    }
}
