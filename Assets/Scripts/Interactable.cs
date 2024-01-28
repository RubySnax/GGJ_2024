using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Interactable : MonoBehaviour
{
    public bool isInRange;
    public KeyCode interactKey1;
    public KeyCode interactKey2;
    public UnityEvent interactAction;

    SpriteRenderer rend;

    void Start()
    {
        rend = this.gameObject.GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        if(isInRange)
        { 
            if(Input.GetKeyDown(interactKey1))
            {
                interactAction.Invoke();
            }
        }

        if(Input.GetKeyDown(interactKey1) && isInRange)
        {
            rend.enabled = !rend.enabled;
        }

        if(isInRange == false)
        {
            rend.enabled = false;
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Player now in range");
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isInRange = false;
        Debug.Log("Player now NOT in range");
    }

}
