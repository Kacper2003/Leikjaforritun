using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageZone : MonoBehaviour
{
    void OnTriggerStay2D(Collider2D other) // Trigger þegar snert er Damage Zone
    {
        RubyController controller = other.GetComponent<RubyController>(); // Fá Ruby sem object

        if (controller != null)
        {
            controller.ChangeHealth(-1); // Taka 1 af Health hjá Ruby
        }
    }

}
