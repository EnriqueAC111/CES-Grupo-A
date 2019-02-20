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


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
        animacionFondo = fondo.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Mundo1Pulsado()
    {
        anim.SetBool("Pulsado", true);
        animacionFondo.SetBool("Pulsado", true);
        botonLvl1.SetActive(true);
        botonLvl2.SetActive(true);
        botonLvl3.SetActive(true);

    }


}
