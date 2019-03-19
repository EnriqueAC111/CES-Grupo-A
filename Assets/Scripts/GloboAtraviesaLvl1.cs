using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GloboAtraviesaLvl1 : MonoBehaviour
{
    //Creamos en público los componentes necesarios para cumplir con la función de atravesar a "Kaze"
    //(que solo ocurre en el nivel 1) que más tarde vincularemos en el inspector de Unity

    public Collider2D col;
    public Collider2D colKaze;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Si el collider del game object poseedor de este script está tocando o toca el collider 
        //que vincularemos de Kaze, entonces, este primer collider se transformará a trigger
        //permitiendo así que el globo atraviese a "Kaze" y no quede bloqueado o entorpeza la jugabilidad
        if(col.IsTouching(colKaze))
        {
                col.isTrigger = true;
        }
        
    }


}
