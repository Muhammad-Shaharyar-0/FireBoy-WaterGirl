using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public static bool Redflag;
    public static bool Blueflag;
    [SerializeField] GameManager gm;

    private void Start()
    {
        Redflag = false;
        Blueflag = false;
    }
    private void Update()
    {
        if(Redflag==true && Blueflag==true)
        {
            gm.LeveCompleted();
        }
    }
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (gameObject.CompareTag(collision.gameObject.tag))
        {
            if(gameObject.tag=="Red")
            {
                Redflag = true;
            }
            else if(gameObject.tag == "Blue")
            {
                Blueflag = true;
            }
        }
    }
}
