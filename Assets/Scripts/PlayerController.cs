using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float playerSpeed;
    public GameObject projectilePrefab;
    public Transform firePoint;
    public float timeBetweenProjectiles;


    private Rigidbody2D rb;
    private Vector2 leftStickInput;
    private Vector2 rightStickInput;
    private bool canShoot;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        canShoot = true;
    }

    void Update()
    {
        GetPlayerInput();
    }

    private void GetPlayerInput()
    {
        leftStickInput = new Vector2(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"));
        rightStickInput = new Vector2(Input.GetAxis("R_Horizontal"), Input.GetAxis("R_Vertical"));

        if(Input.GetButton("Shoot") && canShoot)
        {
            Shoot();
        }
    }

    private void Shoot()
    {
        canShoot = false;
        Instantiate(projectilePrefab, firePoint.position, transform.rotation);
        StartCoroutine(ShotCooldown());
    }

    IEnumerator ShotCooldown()
    {
        yield return new WaitForSeconds(timeBetweenProjectiles);
        canShoot = true;
    }

    private void FixedUpdate()
    {
        Vector2 curMovement = leftStickInput * playerSpeed * Time.deltaTime;

        rb.MovePosition(rb.position + curMovement);

        if(rightStickInput.magnitude > 0F)
        {
            Vector3 curRotation = Vector3.left * rightStickInput.x + Vector3.up * rightStickInput.y;
            Quaternion playerRotation = Quaternion.LookRotation(curRotation, Vector3.forward);

            rb.SetRotation(playerRotation);
        }
    }
}
