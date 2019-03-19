using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mundo1 : MonoBehaviour
{
    //Creamos un "bool" que determinará el estado "desaparecido" del "mundo" en cuestión
    bool desaparecido = false;



    //Creamos una función que determine lo siguiente:
    public void Desaparece()
    {
        //si el bool anteriormente descrito es "false", el game object poseedor de este script
        //se desactivará y, por lo tanto, el bool "desaparecido" será "true"
        if (!desaparecido)
        {
            gameObject.SetActive(false);
            desaparecido = true;
        }
        //en caso contrario, se activará la función "aparece" con un delay de 0.4s
        else
        {
            Invoke("Aparece", 0.4f);
        }

    }
    //Creamos la función "aparece" que hará que el game object poseedor de este script
    //se active y el bool "desaparecido" pase a ser "false"
    void Aparece()
    {
        gameObject.SetActive(true);
        desaparecido = false;
    }
}
