using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComeTuerca : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
		//distance = Vector2 (gameObject.transform.position, gameObject.CompareTag ("Tuerca").transform.position);
    }

    // Update is called once per frame
    void Update()
    {

    }

	void OnTriggerEnter2D (Collider2D other)
	{
        if (other.gameObject.CompareTag("Tuerca"))
        {
            Destroy(other.gameObject);
        }
	}
}
