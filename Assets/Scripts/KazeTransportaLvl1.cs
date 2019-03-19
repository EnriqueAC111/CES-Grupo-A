using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KazeTransportaLvl1 : MonoBehaviour
{
    //Llamamos a los componentes necesarios para que cumpla con la función de transportar (ruta preestablecida
    //del nivel 1)
    HingeJoint2D hj;
    public Rigidbody2D rbTuerca;
    Animator anim;

    void Start()
    {
       //Inicializamos los componentes de este game object (Kaze)
       hj = GetComponent<HingeJoint2D>(); 
       anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Si el "hinge joint" de Kaze está conectado al rigidbody de la tuerca (a la tuerca), entonces se activará
        //la animación que hará que complete la ruta pre-descrita
        if(hj.connectedBody == rbTuerca )
        {
            anim.SetBool("TuercaCogida", true);
        }
        
    }
}
