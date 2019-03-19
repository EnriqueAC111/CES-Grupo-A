using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cuerda : MonoBehaviour
{
    //Llamamos a los componentes del propio game object que interferirán en el funcionamiento de esta mecánica
    LineRenderer lr;
    HingeJoint2D hj2d;

    //Creamos un bool que determinará el estado de "conectado" de la cuerda
    bool conectado = true;
    // Start is called before the first frame update
    void Start()
    {
        //Inicializamos los componentes anteriormente llamados
        lr = GetComponent<LineRenderer>();
        hj2d = GetComponent<HingeJoint2D>();
        //Especificamos el número de vértices del line renderer en cuestión
        lr.positionCount = 2;
    }

    // Update is called once per frame
    void Update()
    {
        //Si el bool "conectado" es "true": el primer vértice se situará en la posición del game object y el segundo en la posición del game object al
        //que se encuentra conectado por "hinge joint"
        if (conectado)
        {
            lr.SetPosition(0, transform.position);
            lr.SetPosition(1, hj2d.connectedBody.transform.position);
        }

    }
    //Creamos una función "OnTriggerEnter" con la condición de que, al detectar cuando el trigger de este game object interceda con el de otro game object con la etiqueta
    //de "Player", se destruya el "hinge joint" y el "line renderer" rompiendo de esta manera la conexión entre los núcleos de la cuerda
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(hj2d);
            Destroy(lr);
            //conectado = false;
        }
    }

    //Creamos una función "OnCollisionEnter" con la condición de que, al detectar cuando el collider de este game object interceda con el de otro game object
    //con la etique de "Player", se destruta el "hinge joint" y el "line renderer" (en principio el collider de la cuerda es trigger, pero en determinado
    //nivel precisa que éste no lo sea y de esta manera poder soportar objetos sobre las cuerdas)
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            Destroy(hj2d);
            Destroy(lr);
            //conectado = false;
        }
        
    }
}