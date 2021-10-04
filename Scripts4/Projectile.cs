using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Projectile : MonoBehaviour
{
    Rigidbody2D rigidbody2d;

    void Awake()
    {
        rigidbody2d = GetComponent<Rigidbody2D>(); // Fá Rigidbody sem object
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.magnitude > 100.0f) // Ef Projectile fer of lang er eytt því
        {
            Destroy(gameObject);
        }
    }

    public void Launch(Vector2 direction, float force) // Láta Projectile hreyfast
    {
        rigidbody2d.AddForce(direction * force);
    }

    void OnCollisionEnter2D(Collision2D other)
    {
        EnemyController e = other.collider.GetComponent<EnemyController>(); // Ef Projectile collide'ar við Robot
        if (e != null)
        {
            e.Fix(); // Kalla á fall sem fix'ar Robot
        }

        Destroy(gameObject); // Eyða Projectile
    }
}
