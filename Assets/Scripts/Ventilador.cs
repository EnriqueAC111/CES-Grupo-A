using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ventilador : MonoBehaviour
{

    PointEffector2D pe;
    Animator anim;
    

    // Start is called before the first frame update
    void Start()
    {
        pe = GetComponent<PointEffector2D>();
        pe.enabled = false;
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ventiladorActivado()
    {
        pe.enabled = true;
       // anim.SetBool("", true);
    }

    private void OnMouseDown()
    {
        Debug.Log("tocado");
        ventiladorActivado();
    }




}
