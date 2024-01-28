using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FakeDoorDestroy : MonoBehaviour
{
    public AudioSource audioSource;
    SpriteRenderer rend;

    public void Start()
    {
        rend = this.gameObject.GetComponent<SpriteRenderer>();
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player Touched");
            audioSource.Play();
            this.gameObject.SetActive(false);
            rend.enabled = false;
        }
    }
}
