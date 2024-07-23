using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Interactable : MonoBehaviour
{
    //message displayed to prompt player for Interactable
    public string promptMessage;

    //this function is called from player.

    public void BaseInteract()
    {
        Interact();
    }
    protected virtual void Interact()
    {
    // this is a template func to be overridden
    }
}
