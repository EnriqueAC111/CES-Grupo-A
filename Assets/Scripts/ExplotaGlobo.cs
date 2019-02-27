using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplotaGlobo : MonoBehaviour
{

    public ParticleSystem particulas;
    public GameObject particles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        Instantiate(particles, transform.position, transform.rotation);
        Destroy(gameObject);  
        particulas.Play();
    } 
}
