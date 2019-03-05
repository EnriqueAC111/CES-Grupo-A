using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mundo1Accion : MonoBehaviour
{

    Animator anim;
    public Animator animacionFondo;
    public GameObject fondo;
    public GameObject botonLvl1;
    public GameObject botonLvl2;
    public GameObject botonLvl3;

    bool pulsado = false;

    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        animacionFondo = fondo.GetComponent<Animator>();
    }


    public void Mundo1Pulsado()
    {
        if (!pulsado)
        {
            anim.SetBool("Pulsado", true);
            animacionFondo.SetBool("Pulsado", true);
            botonLvl1.SetActive(true);
            botonLvl2.SetActive(true);
            botonLvl3.SetActive(true);

            pulsado = true;
        }
        else
        {
            anim.SetBool("Pulsado", false);
            animacionFondo.SetBool("Pulsado", false);
            botonLvl1.SetActive(false);
            botonLvl2.SetActive(false);
            botonLvl3.SetActive(false);

            pulsado = false;
        }
    }
}
