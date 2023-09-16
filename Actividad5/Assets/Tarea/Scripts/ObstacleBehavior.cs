using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleBehavior : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
            Destroy(collision.gameObject);
        }

        if (collision.CompareTag("Trash"))
        {
            Destroy(gameObject);
        }
    }
}
