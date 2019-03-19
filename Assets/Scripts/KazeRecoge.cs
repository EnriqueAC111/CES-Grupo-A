using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KazeRecoge : MonoBehaviour
{
    //Llamamos a los componentes/elementos que interferirán en la mecánica de "recoger" de este game object
    HingeJoint2D hj;
    public Collider2D colCes;

    public GameObject Anclaje;


    public AudioSource sonidoKaze;
    public Canvas PantallaFinal;

    // Start is called before the first frame update
    void Start()
    {
        //Inicilizamos el componente de este game object
        hj = gameObject.GetComponent<HingeJoint2D>();
        
    }

    private void Update()
    {
        //en cada frame se cerciorará si se cumple esta condición: si la pantalla final está activada, el sonido de "kaze"
        //parará de reproducirse
        if(PantallaFinal.isActiveAndEnabled == true)
        {
            sonidoKaze.Stop();
        }
    }

    //Creamos una función "OnTriggerEnter" que hará que el collider de este game object detecte cuando se interponga al de otro
    //game object con las condiciones siguientes:
    void OnTriggerEnter2D(Collider2D other)
    {
        //Si el game object que se encuentra en esta situación tiene adherida la etiqueta de "Tuerca", la posición de éste será la posición
        //del "punto de anclaje" referido al principio y el objeto conectado al "hinge joint" de "kaze" será este game object (Tuerca o CES)
        if (other.gameObject.CompareTag("Tuerca"))
        {
            other.transform.position = Anclaje.transform.position;
            hj.connectedBody = other.GetComponent<Rigidbody2D>();
            
        }
        //En caso de ser CES, además, su collider (nombrado y hecho público al principio para su posterior vinculación) se desactivará
        if (other.gameObject.CompareTag("CES"))
        {
            other.transform.position = Anclaje.transform.position;
            hj.connectedBody = other.GetComponent<Rigidbody2D>();
            colCes.enabled = false;
            
        }
        
    }
    
    /*
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Tuerca"))
        {
            gameObject.transform.position = hj.transform.position;
            hj.connectedBody = collision.gameObject.GetComponent<Rigidbody2D>();
        }
    }
    */
    
    //Creamos función de "OnMouseDown" para que al "clickar" sobre el game object poseedor de este script, el objeto conectado a su
    //"hinge joint" adherido, será nulo, es decir, no tendrá un game object (con rigidbody, obligatoriamente) conectado
    private void OnMouseDown()
    {
        hj.connectedBody = null;
    
    }
}
