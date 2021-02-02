﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WASDcontrol : MonoBehaviour
{

    public float forceAmt;

    private Rigidbody rb;
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.W))
        {
            rb.AddForce(Vector3.forward * forceAmt);
        }
    }
}
