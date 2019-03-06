using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KazeRecoge : MonoBehaviour
{

    Rigidbody2D rb;
    HingeJoint2D hj;
    public Collider2D colCes;

    public GameObject Anclaje;


    public EfectosSonido efs;

    // Start is called before the first frame update
    void Start()
    {
        rb = gameObject.GetComponent<Rigidbody2D>();
        hj = gameObject.GetComponent<HingeJoint2D>();
        efs.SonidoKaze();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Tuerca"))
        {
            other.transform.position = Anclaje.transform.position;
            hj.connectedBody = other.GetComponent<Rigidbody2D>();
            
        }
        if (other.gameObject.CompareTag("CES"))
        {
            other.transform.position = Anclaje.transform.position;
            hj.connectedBody = other.GetComponent<Rigidbody2D>();
            colCes.enabled = false;
            
        }
        
    }
    
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Tuerca"))
        {
            gameObject.transform.position = hj.transform.position;
            hj.connectedBody = collision.gameObject.GetComponent<Rigidbody2D>();
        }
    }
    */


    private void OnMouseDown()
    {
        hj.connectedBody = null;
    
    }
}
