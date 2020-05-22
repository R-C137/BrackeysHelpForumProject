using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KIllOnTouch : MonoBehaviour
{
    private void OnCollisionEnter(Collision collision)
    {
       var ply = collision.collider.GetComponent<Movement>();
        ply.Death();
    }
}
