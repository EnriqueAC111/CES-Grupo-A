using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mundo1Accion : MonoBehaviour
{

    Animator anim;
    public Animator animacionFondo;
    public GameObject fondo;

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
    }


}
