using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoominkController : MonoBehaviour
{


    public GameObject tuerca;
    Rigidbody2D rbTuerca;
    Animator animator;
    public GameObject vortice;


    public float velocidad = 100f;

    public EfectosSonido efs;


    // Start is called before the first frame update
    void Start()
    {
        rbTuerca = tuerca.GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if ((Input.GetMouseButtonDown(0)) && (tuerca.transform.IsChildOf(gameObject.transform)))
        {
            transform.DetachChildren();
            rbTuerca.isKinematic = false;
            rbTuerca.AddForce(transform.up * velocidad);
            animator.SetBool("Tocar", true);
            efs.SonidoBoomink();
            Debug.Log("RATONAZO");
            
        }
        if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("Tocar", false);
        }
    }


    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Tuerca"))
        {
            collision.transform.SetParent(gameObject.transform);
            tuerca.transform.position = Vector3.MoveTowards(tuerca.transform.position, vortice.transform.position, Time.deltaTime);
            rbTuerca.isKinematic = true;
            
        }

    }



}
