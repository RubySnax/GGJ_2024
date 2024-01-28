using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Key : MonoBehaviour
{

    public GameObject door;
    [SerializeField] private AudioSource keySoundEffect;
    SpriteRenderer rend;

    public void Start()
    {
        rend = door.gameObject.GetComponent<SpriteRenderer>();
    }

    private void Update()
    {

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            keySoundEffect.Play();
            Debug.Log("key picked up");

            door.GetComponent<BoxCollider2D>().enabled = false;
            rend.enabled = false;
            this.gameObject.SetActive(false);

        }
    }
}
