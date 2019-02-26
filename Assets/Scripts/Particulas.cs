using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particulas : MonoBehaviour
{
    public GameObject particulas;
    public ParticleSystem particules;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void Awake()
    {
		
    }

    // Update is called once per frame
    void Update()
    {
		
    }

	void OnTriggerEnter2D(Collider2D other)
	{
		if(other.gameObject.CompareTag("Tuerca"))
		{
			particulas.SetActive(true);
		}
		if(other.gameObject.CompareTag("CES"))
		{
			particulas.SetActive(true);
		}
			
	}
}
