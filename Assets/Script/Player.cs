using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    [SerializeField] private LayerMask platform;
    [SerializeField] float jumpvelocity=5f;

        Rigidbody2D rb;
    CapsuleCollider2D capsulecollider;
    // Start is called before the first frame update
    void Start()
    {
     
        rb= GetComponent<Rigidbody2D>();
        capsulecollider = GetComponent<CapsuleCollider2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.CompareTag("Blue"))
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                if (IsGrounded())
                {

                    //rb.AddForce(Vector2.up * jumpvelocity, ForceMode2D.Impulse);
                     rb.velocity = new Vector2(rb.velocity.x, jumpvelocity);

                }
            }
        }
        else
        {

            if (Input.GetKeyDown(KeyCode.UpArrow))
            {
                if (IsGrounded())
                {

                    //rb.AddForce(Vector2.up * jumpvelocity, ForceMode2D.Impulse);
                    rb.velocity = new Vector2(rb.velocity.x, jumpvelocity);
                    // rb.velocity = Vector2.up * jumpvelocity;

                }
            }
        }

    }
    private void FixedUpdate()
    {
        if (gameObject.CompareTag("Blue"))
        {

            if (Input.GetKey(KeyCode.A))
            {
                // Debug.Log(rb.velocity.magnitude);
                //  if (rb.velocity.magnitude < 3f)
                rb.velocity = Vector3.Lerp(rb.velocity, new Vector2(-4f, rb.velocity.y), 0.09f);
                // rb.AddForce(-Vector2.right * 7f);
                //rb.velocity = new Vector2(-2f, rb.velocity.y);
                //transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);
            }
            else if (Input.GetKey(KeyCode.D))
            {

                rb.velocity = Vector3.Lerp(rb.velocity, new Vector2(4f, rb.velocity.y), 0.09f);
                // transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);
            }
            else
                rb.velocity = new Vector2(0, rb.velocity.y);
        }
        else
        {
            if (Input.GetKey(KeyCode.LeftArrow))
            {
                // Debug.Log(rb.velocity.magnitude);
                //  if (rb.velocity.magnitude < 3f)
                rb.velocity = Vector3.Lerp(rb.velocity, new Vector2(-4.5f, rb.velocity.y), 0.08f);
                // rb.AddForce(-Vector2.right * 7f);
                //rb.velocity = new Vector2(-2f, rb.velocity.y);
                //transform.position = new Vector3(transform.position.x - 0.1f, transform.position.y, transform.position.z);
            }
            else if (Input.GetKey(KeyCode.RightArrow))
            {

                rb.velocity = Vector3.Lerp(rb.velocity, new Vector2(4.5f, rb.velocity.y), 0.08f);
                // transform.position = new Vector3(transform.position.x + 0.1f, transform.position.y, transform.position.z);
            }
            else
                rb.velocity = new Vector2(0, rb.velocity.y);
        }
    }
  
    private bool IsGrounded()
    {
        
        RaycastHit2D r = Physics2D.Raycast(capsulecollider.bounds.center,Vector2.down,1f, platform);
        return r.collider != null;
    }
}
