using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletSpaceShop : MonoBehaviour
{
    private Rigidbody2D rigidB2D;
    [SerializeField] private float bulletSpeed = 100f;

    private void Start()
    {
        rigidB2D = GetComponent<Rigidbody2D>();
    }

    private void FixedUpdate()
    {
        rigidB2D.AddForce(transform.up * bulletSpeed, ForceMode2D.Force);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Barriers"))
        {
            Destroy(gameObject);
        }
    }
}
