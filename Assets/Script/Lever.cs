using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lever : MonoBehaviour
{
    public bool MoveLift;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Rigidbody2D rb=collision.gameObject.GetComponent<Rigidbody2D>();
        if(rb.velocity.x<0f)
            MoveLift = true;
        else
        {
            MoveLift = false;
        }
    }
}
