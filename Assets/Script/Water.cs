using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Water : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(!gameObject.CompareTag(collision.gameObject.tag))
        {
            Debug.Log("Death");
        }
    }
}
