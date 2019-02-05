using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComeTuerca : MonoBehaviour
{
	public GameObject tuerca;
	float distance;
	bool cerca;
    // Start is called before the first frame update
    void Start()
    {
		//distance = Vector2 (gameObject.transform.position, gameObject.CompareTag ("Tuerca").transform.position);
    }

    // Update is called once per frame
    void Update()
    {
		distance = Vector3.Distance (gameObject.transform.position, tuerca.transform.position);
		Debug.Log (distance);
    }

	void OnTriggerEnter2D (Collider2D other)
	{
		tuerca.SetActive (false);
	}
}
