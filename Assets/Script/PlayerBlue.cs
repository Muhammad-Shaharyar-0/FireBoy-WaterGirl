using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerBlue : MonoBehaviour
{
    [SerializeField] float jumpvelocity=5f;
    private bool onground;
        Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {
        onground = true;
        rb= GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            if (onground == true)
                rb.AddForce(Vector2.up * jumpvelocity, ForceMode2D.Impulse);
            // rb.velocity = Vector2.up * jumpvelocity;
            onground = false;
        }

    }
    private void FixedUpdate()
    {
        
       
        if (Input.GetKey(KeyCode.LeftArrow))
        {
           // Debug.Log(rb.velocity.magnitude);
          //  if (rb.velocity.magnitude < 3f)
                rb.velocity = Vector3.Lerp(rb.velocity, new Vector2(-4f, rb.velocity.y), 0.08f);
            // rb.AddForce(-Vector2.right * 7f);
            //rb.velocity = new Vector2(-2f, rb.velocity.y);
            //transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
           
             rb.velocity = Vector3.Lerp(rb.velocity, new Vector2(4f, rb.velocity.y), 0.08f);
            // transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);
        }
        else
            rb.velocity = new Vector2(0, rb.velocity.y);
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("Ground"))
        {
            onground = true;
        }
    }
}
