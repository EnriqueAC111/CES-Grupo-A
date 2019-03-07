using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KazeRecoge : MonoBehaviour
{

    HingeJoint2D hj;
    public Collider2D colCes;

    public GameObject Anclaje;


    public AudioSource sonidoKaze;
    public Canvas PantallaFinal;

    // Start is called before the first frame update
    void Start()
    {
        hj = gameObject.GetComponent<HingeJoint2D>();
        
    }

    private void Update()
    {
        if(PantallaFinal.isActiveAndEnabled == true)
        {
            sonidoKaze.Stop();
        }
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
