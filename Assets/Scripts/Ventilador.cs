using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ventilador : MonoBehaviour
{

    PointEffector2D pe;
    Animator anim;
    


    public EfectosSonido efs;

    // Start is called before the first frame update
    void Start()
    {
        pe = GetComponent<PointEffector2D>();
        pe.enabled = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame

    private void OnMouseDown()
    {
        Debug.Log("tocado");
        pe.enabled = true;
        anim.SetBool("Activado", true);
        efs.SonidoVentilador();
    }
    private void OnMouseUp()
    {
        Debug.Log("tocado");
        pe.enabled = false;
        anim.SetBool("Activado", false);
    }




}
