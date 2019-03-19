using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Puntos : MonoBehaviour
{
    //Declaramos los elementos que intervendrán en el funcionamiento de este script como públicos
    //para más tarde vincular en el inspector de Unity
	public RawImage rayo1cont;
	public RawImage rayo2cont;
	public RawImage rayo3cont;
	public RawImage rayo1rell;
	public RawImage rayo2rell;
	public RawImage rayo3rell;
    public EfectosSonido efs;


    // Start is called before the first frame update
    void Start()
    {
        //Los rayos "huecos" o no rellenos se inicializarán como activos mientras que los rellenos no
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

    //Creamos una función "OnTriggerEnter" para que cuando el trigger de este game object (rayo) detecte al de
    //otro game object ocurra lo siguiente:
	void OnTriggerEnter2D(Collider2D other)
	{
        //Si el game object detectado tiene asignada la etiqueta de "Tuerca" o "CES" y además el primer rayo
        //hueco o no relleno de los 3 que hay se encuentre activo (es decir, que aun no se haya rellenado porque
        //no ha sido "cogido" un primer rayo), el primer rayo hueco del HUD se desactivará y el relleno se activará
        //Además se activará el efecto de sonido de "recogida de rayo" y éste se destruirá (el rayo en cuestión)
        //Lo mismo ocurrirá en los siguientes condicionantes respecto a los siguientes 2 rayos
		if((other.gameObject.CompareTag("Tuerca")||other.gameObject.CompareTag("CES")) && rayo1cont.enabled==true)
		{
			rayo1cont.enabled = false;
			rayo1rell.enabled = true;
            efs.SonidoRayo();
			Destroy(gameObject);
		}else if((other.gameObject.CompareTag("Tuerca")||other.gameObject.CompareTag("CES")) && rayo1rell.enabled==true && 
			rayo2cont.enabled==true)
		{
			rayo2cont.enabled = false;
			rayo2rell.enabled = true;
			Destroy(gameObject);
            efs.SonidoRayo();

        }
        else if((other.gameObject.CompareTag("Tuerca")||other.gameObject.CompareTag("CES")) && rayo1rell.enabled==true && 
			rayo2rell.enabled==true && rayo3cont.enabled==true)
		{
			rayo3cont.enabled = false;
			rayo3rell.enabled = true;
			Destroy(gameObject);
            efs.SonidoRayo();
        }


	}

}
