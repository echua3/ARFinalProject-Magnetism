using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingParticle : ChargedParticle
{
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.AddComponent<Rigidbody>();

        //do not apply gravity to particle
        rb.useGravity = false;
        
    }

    
}
