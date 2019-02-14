using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KazeRecoge : MonoBehaviour
{

    Rigidbody2D rb;
    HingeJoint2D hj;
    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        hj = gameObject.GetComponent<HingeJoint2D>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        hj.connectedBody = other.GetComponent<Rigidbody2D>();
    }

    private void OnMouseDown()
    {
        gameObject.transform.DetachChildren();
    }
}
