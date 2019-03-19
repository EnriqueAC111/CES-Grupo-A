using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particulas : MonoBehaviour
{
    //Creamos como público los diferentes elementos/componentes que lleve a cabo esta función
    //que más tarde vincularemos en el inspector de Unity
    public GameObject particulas;
    public ParticleSystem particules;

    // Start is called before the first frame update
    void Start()
    {
        
    }


    // Update is called once per frame
    void Update()
    {
		
    }
    
    //Creamos una función "OnTriggerEnter" para que cuando el trigger del game object poseedor de este script
    //detecte el de otro game object ocurra lo siguiente:
	void OnTriggerEnter2D(Collider2D other)
	{
        //Si el game object intercedente tiene la etiqueta de "Tuerca" o "CES", las particulas declaradas anteriormente
        //se activarán tanto a nivel visual como a nivel anímico
		if(other.gameObject.CompareTag("Tuerca"))
		{
			particulas.SetActive(true);
            particules.Play();
		}
		if(other.gameObject.CompareTag("CES"))
		{
			particulas.SetActive(true);
            particules.Play();
		}
			
	}
}
