using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressE : MonoBehaviour
{
    public bool isInRange;
    public GameObject eKey;

    SpriteRenderer rend;


    void Start()
    {
        rend = eKey.gameObject.GetComponent<SpriteRenderer>();
    }


    void Update()
    {
        if (isInRange == false)
        {
            rend.enabled = false;
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        isInRange = false;
        Debug.Log("Player now NOT in range");
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            isInRange = true;
            Debug.Log("Player now in range");
        }
    }


}