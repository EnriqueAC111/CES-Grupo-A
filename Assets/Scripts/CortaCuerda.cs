using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Este script sirve para cortar la cuerda. Sigue el movimiento del ratón al mantener el click izquierdo.

public class CortaCuerda : MonoBehaviour
{

    //Creamos un vector 2 que definirá la posición del ratón
	private Vector2 mousePosition;
	//Velocidad del cursor, variable pública para poder ser modificada en el "inspector" de Unity
	public float moveSpeed = 0.1f;
    //Llamamos al collider
    Collider2D col;
    //Creamos los componentes públicos del "collider" ventilador y "point effector" que más tarde vincularemos en el "inspector" de Unity
    public Collider2D colVentilador;
    public PointEffector2D peVentilador;
	// Start is called before the first frame update
	void Start()
	{
        //Hacemos que el objecto vacío poseedor de este script se encuentre activo desde el inicio de la escena
        gameObject.SetActive(true);
        //Inicializamos el collider del propio game object
        col = GetComponent<Collider2D>();
        //Desactivamos el collider en el inicio para que no se interponga a nada 
        col.enabled = false;
    }

	// Update is called once per frame
	void Update()
	{

        //Al "clickar" con el click izquierdo del ratón sobre la pantalla ocurre lo siguiente (comentarios pertenecientes a los contenidos del "if"):
        if (Input.GetMouseButton(0)) {
			//Reproduccion en consola para asegurar el funcionamiento
			Debug.Log("Mouse");
			//Para saber donde está la posición del ratón (el vector 2 que nombramos y creamos al principio será el resultado de la posición del ratón en todo momento
            //, ya que se encuentra en el update)
			mousePosition = Input.mousePosition;
			//Donde "clickas" tienes la posicion de la camara
			mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);
			//Para que se mueva el game object a la posición del ratón
			transform.position = mousePosition;
            //Activamos el collider
            col.enabled = true;
		}
        //Cuando levantamos el click izquierdo el collider se desactiva como estaba en un principio
        if (Input.GetMouseButtonUp(0))
        {
            col.enabled = false;
        }
        //Si el collider está detectando al collider del ventilador, este primero se desactiva, impidiendo que intervenga de forma negativa en la jugabilidad
        if (col.IsTouching(colVentilador))
        {
            col.enabled = false;
        }
 


	}
    //Creamos una función "OnTriggerEnter" que hará que el trigger detecte cuando el game object con la etiqueta de ventilador entre en contacto con éste primero y,
    //una vez ocurrido esto, el "point effector" del ventilador se active 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag ("Ventilador"))
        {
            peVentilador.enabled = true;
        }
    }

}