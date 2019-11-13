using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleDeleter : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("ObstacaleDeleter"))
        {
            Destroy(gameObject);
        }
       
    }
}
