using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionObject : MonoBehaviour
{
    public enum InteractionType
    {
        Nothing,
        Pickup,
        Info,
        Dialogue
    }

    [Header("Type of Interactable")]
    public InteractionType interType;

    public void Interact()
    {

    }

    public void Nothing()
    {

    }

    public void Pickup()
    {

    }

    public void Info()
    {

    }

    public void Dialogue()
    {

    }
}
