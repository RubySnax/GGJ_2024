using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeDoorDestroy : MonoBehaviour
{
    SpriteRenderer rend;

    public void Start()
    {
        rend = this.gameObject.GetComponent<SpriteRenderer>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player Touched");
            this.gameObject.SetActive(false);
            rend.enabled = false;
        }
    }
}
