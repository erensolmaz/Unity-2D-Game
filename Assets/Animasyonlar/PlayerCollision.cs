using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
    public PlayerHareket movement;
    public GameManager gameManager;

    void OnCollisionEnter2D (Collision2D collisionInfo)
    {
        if (collisionInfo.collider.tag == "fire")
        {
            movement.enabled = false;
            FindObjectOfType<GameManager>().EndGame();
        }
    }
    void OnTriggerEnter2D (Collider2D other)
        {
            if (other.gameObject.CompareTag("coin"))
            {
                Destroy(other.gameObject);
            }
        
    }


}
