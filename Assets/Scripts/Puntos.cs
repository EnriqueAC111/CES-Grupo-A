using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
	public RawImage rayo1cont;
	public RawImage rayo2cont;
	public RawImage rayo3cont;
	public RawImage rayo1rell;
	public RawImage rayo2rell;
	public RawImage rayo3rell;

    // Start is called before the first frame update
    void Start()
    {
		rayo1cont.enabled = true;
		rayo2cont.enabled = true;
		rayo3cont.enabled = true;
		rayo1rell.enabled = false;
		rayo2rell.enabled = false;
		rayo3rell.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnTriggerEnter2D(Collider2D other)
	{
		if((other.gameObject.CompareTag("Tuerca")||other.gameObject.CompareTag("CES")) && rayo1cont.enabled==true)
		{
			rayo1cont.enabled = false;
			rayo1rell.enabled = true;
		}else if((other.gameObject.CompareTag("Tuerca")||other.gameObject.CompareTag("CES")) && rayo1rell.enabled==true && 
			rayo2cont.enabled==true)
		{
			rayo2cont.enabled = false;
			rayo2rell.enabled = true;
		}else if((other.gameObject.CompareTag("Tuerca")||other.gameObject.CompareTag("CES")) && rayo1rell.enabled==true && 
			rayo2rell.enabled==true && rayo3cont.enabled==true)
		{
			rayo3cont.enabled = false;
			rayo3rell.enabled = true;
		}

		Destroy(gameObject);
	}

}
