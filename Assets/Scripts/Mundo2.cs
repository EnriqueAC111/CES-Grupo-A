using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mundo2 : MonoBehaviour
{
    bool desaparecido = false;




    public void Desaparece()
    {
        if (!desaparecido)
        {
            gameObject.SetActive(false);
            desaparecido = true;
        }
        else
        {
            Invoke("Aparece", 0.4f);
        }

    }

    void Aparece()
    {
        gameObject.SetActive(true);
        desaparecido = false;
    }
}
