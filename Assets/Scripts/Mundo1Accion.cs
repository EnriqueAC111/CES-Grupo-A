using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mundo1Accion : MonoBehaviour
{
    //Llamamos al "animator" del game object y creamos los elementos/componentes en "público" que intercederán
    //en la función de accionar el mundo para más tarde vincular mediante el inspector de Unity
    Animator anim;
    public Animator animacionFondo;
    public GameObject fondo;
    public GameObject botonLvl1;
    public GameObject botonLvl2;
    public GameObject botonLvl3;

    //Creamos "bool" de "pulsado" para detectar el estado de si ha sido pulsado o no (en principio será "false")
    bool pulsado = false;

    // Start is called before the first frame update
    void Start()
    {
        //Inicializamos los componentes del game object y el de "animacionFondo" (externo a este game object, hecho porque sí,
        //podiendo haberse vinculador desde el inspector)
        anim = GetComponent<Animator>();
        animacionFondo = fondo.GetComponent<Animator>();
    }

    //Creamos la función de "mundoPulsado" que diferenciará que hará el botón al pulsarse diferenciando de si el "bool"
    //creado y nombrado al principio se encuentra en "true" o no
    public void Mundo1Pulsado()
    {
        //si se ha pulsado, los botones se activarán, así como la animación del botón y fondo respectivo
        if (!pulsado)
        {
            anim.SetBool("Pulsado", true);
            animacionFondo.SetBool("Pulsado", true);
            botonLvl1.SetActive(true);
            botonLvl2.SetActive(true);
            botonLvl3.SetActive(true);

            pulsado = true;
        }
        //en caso de que no se haya pulsado, ocurrirá lo contario a lo anterior
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
