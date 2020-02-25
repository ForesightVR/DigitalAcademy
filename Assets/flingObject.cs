using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class flingObject : MonoBehaviour
{
    public float flingHeight = 50f;
    public float flingDistance = 50f;

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "obsticle")
        {
            Rigidbody obsticle = collision.transform.GetComponent<Rigidbody>();
            obsticle.AddForce(0, flingHeight, flingDistance);
        }
    }
}
