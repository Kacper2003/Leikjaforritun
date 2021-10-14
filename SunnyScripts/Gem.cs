using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Gem : MonoBehaviour {
    
    void OnTriggerEnter2D(Collider2D other) {

        Destroy(gameObject);

        PlayerMovement2D controller = other.GetComponent<PlayerMovement2D>();

        if (controller != null)
        { 
            controller.AddScore();
        }
    }
}