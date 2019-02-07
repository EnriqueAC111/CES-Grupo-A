using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoominkController : MonoBehaviour
{


    public GameObject tuerca;
    Rigidbody2D rbTuerca;


    public float velocidad = 100f;


    // Start is called before the first frame update
    void Start()
    {
        rbTuerca = tuerca.GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetMouseButtonDown(0)) && (tuerca.transform.IsChildOf(gameObject.transform)))
        {
            transform.DetachChildren();
            rbTuerca.AddForce(transform.up * velocidad);
            Debug.Log("RATONAZO");
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Tuerca"))
        {
            collision.transform.SetParent(gameObject.transform);
            
        }

    }



}
