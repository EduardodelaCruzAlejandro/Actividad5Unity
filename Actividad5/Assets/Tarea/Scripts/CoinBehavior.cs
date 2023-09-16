using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehavior : MonoBehaviour
{
    [SerializeField] private float cantidadPuntos;
    [SerializeField] private Puntaje puntaje;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Car"))
        {
            
            Destroy(gameObject);  

        }

        if (collision.CompareTag("Trash"))
        {
            Destroy(gameObject);
        }
    }


}
