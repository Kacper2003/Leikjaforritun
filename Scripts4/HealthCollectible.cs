using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthCollectible : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other) 
    {
        RubyController controller = other.GetComponent<RubyController>(); // Fá Ruby sem breytu

        if (controller != null)
        {
            if (controller.health < controller.maxHealth) // Ef Ruby er ekki með fullt Health
            {
                controller.ChangeHealth(1); // Bæta við 1 í health
                Destroy(gameObject); // Eyða HealthCollectible
            }
        }
    }
}