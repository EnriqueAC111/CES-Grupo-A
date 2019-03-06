using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desenganchar : MonoBehaviour
{

	public HingeJoint2D hj;
	public HingeJoint2D hj2;
	public HingeJoint2D hj3;
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
			hj2.enabled = false;
			hj3.enabled = false;

			}
	}
}
