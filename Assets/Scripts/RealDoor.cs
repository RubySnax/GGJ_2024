using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RealDoor : MonoBehaviour
{
    public AudioSource audioSource;

    public void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            Debug.Log("Player Touched");
            audioSource.Play();
        }
    }
}
