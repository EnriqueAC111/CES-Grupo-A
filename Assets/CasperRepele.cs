using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CasperRepele : MonoBehaviour
{
    
    //Llamamos a los componentes necesarios del game object para que cumpla con esta mecánica
    PointEffector2D pe;
    Animator anim;

    void Start()
    {
        //Inicializamos los componentes anteriores y desactivamos el "point effector" en un principio
        anim = GetComponent<Animator>();
        pe = GetComponent<PointEffector2D>();
        pe.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    //Creamos una función "OnMouseDown" que determinará que, al pulsar sobre el game object poseedor de este
    //script y se active el "point effector", la animación (junto al parámetro condicionante de ésta)
    private void OnMouseDown()
    {
        pe.enabled = true;
        anim.SetBool("Tocado", true);
        Debug.Log("TOOOOOOCAO");
    }

    //Al levantar el click sobre el game object el "point effector" se desactivará, por lo que dejará de repeler
    //y además lo haga volver a su animación inicial/estática
    private void OnMouseUp()
    {
        pe.enabled = false;
        anim.SetBool("Tocado", false);
    }
}
