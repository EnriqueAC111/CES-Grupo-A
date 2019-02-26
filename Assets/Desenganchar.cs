using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desenganchar : MonoBehaviour
{

	HingeJoint2D hj;
    // Start is called before the first frame update
    void Start()
    {
		hj = GetComponent<HingeJoint2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Kaze"))
			{
			hj.enabled = false;
			}
	}
}
