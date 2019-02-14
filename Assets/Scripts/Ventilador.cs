using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ventilador : MonoBehaviour
{

    PointEffector2D pe;
    Time temporizador;
    

    // Start is called before the first frame update
    void Start()
    {
        pe = GetComponent<PointEffector2D>();
        pe.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {

    }

    void ventiladorActivado()
    {
        pe.enabled = true;
    }

    private void OnMouseDown()
    {
        Debug.Log("tocado");
        ventiladorActivado();
    }




}
