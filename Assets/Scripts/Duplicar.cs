using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicar : MonoBehaviour
{
    //Creamos el game object "pepeNuevo" que se identificará como el nuevo pepe que se originará más tarde
    GameObject pepeNuevo;
    //Creamos un transform que más tarde vincularemos con el "transform" del objeto vacío referente a éste (que será
    //el punto donde queremos que se origine la réplica/duplicación
    public Transform puntoDuplicacion;
    //Llamamos en público a los "efectos de sonido" que más tarde vincularemos
    public EfectosSonido efs;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }
    //Al "clickar" sobre el game object poseedor de este script "instanciaremos" (generaremos) el game object que nombramos
    //y creamos al principio de este script, en la posición y rotación del "punto de duplicación" nombrado y creado al principio
    //Además activaremos el efecto de sonido de "pepe"
    void OnMouseDown()
    {
        
        pepeNuevo = Instantiate(gameObject, puntoDuplicacion.transform.position, puntoDuplicacion.transform.rotation);
        efs.SonidoPepe();
    }

}
