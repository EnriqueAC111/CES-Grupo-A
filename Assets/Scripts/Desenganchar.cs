using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Desenganchar : MonoBehaviour
{
    //Creamos en público los componentes necesarios para que cumpla con la función/mecánica de "desenganchar"
    //y más tarde vincular desde el inspector
	public HingeJoint2D hj;
	public HingeJoint2D hj2;
	public HingeJoint2D hj3;
    // Start is called before the first frame update
    void Start()
    {
        //Inicializamos el "hinge joint" del propio game object
		hj = GetComponent<HingeJoint2D> ();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Creamos una función "OnTriggerEnter" para que, cuando el trigger de este game object detecte al de otro
    //game object ocurra lo siguiente:
	void OnTriggerEnter2D(Collider2D other)
	{
        //en caso de que el objeto que interceda con el trigger del game object poseedor de este script 
        //con la etiqueta de "Kaze" los "hinge joint" correspondientes se desactivarán, dejándolo libre de conexiones
		if(other.gameObject.CompareTag("Kaze"))
			{
			hj.enabled = false;
			hj2.enabled = false;
			hj3.enabled = false;

			}
	}
}
