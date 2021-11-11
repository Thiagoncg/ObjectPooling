using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSpaceShip : MonoBehaviour
{
    private float horizontal, vertical;
    private float speed = 8f;

    [SerializeField] private Rigidbody2D rg;
    [SerializeField] private GameObject bulletSpaceShip;
    [SerializeField] private GameObject bulletPosition;

    private void Update()
    {
        horizontal = Input.GetAxisRaw("Horizontal");
        vertical = Input.GetAxis("Vertical");

        if (Input.GetButtonDown("Fire1"))
        {
            Fire();
        }
    }

    private void FixedUpdate()
    {
        rg.velocity = new Vector2(horizontal * speed, vertical * speed);
    }

    private void Fire()
    {
        Instantiate(bulletSpaceShip, bulletPosition.transform.position, Quaternion.identity);
    }

}
