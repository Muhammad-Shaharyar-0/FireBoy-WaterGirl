using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Swtich : MonoBehaviour
{
    [SerializeField] Lift2 l;
    [SerializeField] Bridge b;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(l!=null)
            l.moveLift = true;
        if (b != null)
            b.moveLift = true;
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        if (l != null)
            l.moveLift = false;
        if (b != null)
            b.moveLift = false;
    }
}
