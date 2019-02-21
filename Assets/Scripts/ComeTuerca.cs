using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComeTuerca : MonoBehaviour
{
    Animator anim;
    public GameObject tuerca;
    Rigidbody2D rb;
    public Collider2D cuerpo;
    public Collider2D captaTuerca;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Mathf.Round(tuerca.transform.position.y) == Mathf.Round(gameObject.transform.position.y))
        {
            Destroy(tuerca);
        }


    }

	void OnTriggerEnter2D (Collider2D other)
	{
        if (other.gameObject.CompareTag("Tuerca"))
        {
            cuerpo.enabled = false;
            rb.bodyType = RigidbodyType2D.Static;
            anim.SetBool("Comer", true);                  
        }
	}

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Tuerca"))
        {
            tuerca.transform.position = Vector3.MoveTowards(tuerca.transform.position, gameObject.transform.position, Time.deltaTime);
        }
    }
       

}
