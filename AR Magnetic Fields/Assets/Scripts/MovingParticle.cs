using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingParticle : ChargedPart
{
    public Rigidbody rb;
    public float mass = 1;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody>();

        //do not apply gravity to particle
        rb.useGravity = false;
        rb.isKinematic = true;
        //rb.mass = mass;

    }

}
