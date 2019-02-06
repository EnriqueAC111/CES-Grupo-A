﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuerda : MonoBehaviour
{
    LineRenderer lr;
    Rigidbody2D rb2d;
    HingeJoint2D hj2d;

    bool conectado = true;
    // Start is called before the first frame update
    void Start()
    {
        lr = GetComponent<LineRenderer>();
        rb2d = GetComponent<Rigidbody2D>();
        hj2d = GetComponent<HingeJoint2D>();
        lr.positionCount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        if (conectado)
        {
            lr.SetPosition(0, transform.position);
            lr.SetPosition(1, hj2d.connectedBody.transform.position);
        }

    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(hj2d);
            Destroy(lr);
            //conectado = false;
        }
    }
}