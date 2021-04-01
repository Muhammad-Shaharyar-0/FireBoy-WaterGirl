using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fan : MonoBehaviour
{
    private void OnTriggerStay2D(Collider2D collision)
    {
        collision.gameObject.GetComponent<Rigidbody2D>().AddForce(Vector2.up * 0.5f, ForceMode2D.Impulse);
    }
}
