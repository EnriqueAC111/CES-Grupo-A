using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ventilador : MonoBehaviour
{
    //Llamamos a los componentes necesarios del game object para
    //que cumpla con la función deseada
    PointEffector2D pe;
    Animator anim;
    

    //Creamos la clase pública de "EfectosSonido" para más
    //tarde vincular desde el inspector de Unity
    public EfectosSonido efs;

    // Start is called before the first frame update
    void Start()
    {
        //Inicializamos los componentes previos y declaramos
        //el "point effector" desactivado, en un principio
        pe = GetComponent<PointEffector2D>();
        pe.enabled = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame

    //Creamos una función "OnMouseDown" para que al "clickar" sobre el game object
    //poseedor de este script (ventilador) active el "point effector", la animación (para que
    //pase a aquella que precise bajo el parámetro de "Activado") y hacemos que se reproduzca
    //el efecto sonoro en cuestión
    private void OnMouseDown()
    {
        Debug.Log("tocado");
        pe.enabled = true;
        anim.SetBool("Activado", true);
        efs.SonidoVentilador();
    }

    //Al "soltar" el click se desactivará el "point effector" y la animación volverá a su estado
    //por defecto (estático)
    private void OnMouseUp()
    {
        Debug.Log("tocado");
        pe.enabled = false;
        anim.SetBool("Activado", false);
    }




}
