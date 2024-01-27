using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableController : MonoBehaviour
{
    public bool isOpen;
    public Animator animator;

    public void OpenObject()
    {
        if(!isOpen)
        {
            isOpen = true;
            Debug.Log("Interactable is now open");
            animator.SetBool("IsOpen", isOpen);
        }
    }
}
