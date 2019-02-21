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
        particules.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        if(gameObject == null)
        {
            particulas.SetActive(true);
            particules.Play();
        }
    }
}
