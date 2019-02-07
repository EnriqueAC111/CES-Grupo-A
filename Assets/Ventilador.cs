using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ventilador : MonoBehaviour
{

    PointEffector2D pe;

    // Start is called before the first frame update
    void Start()
    {
        pe = GetComponent<PointEffector2D>();
        pe.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Invoke("ventiladorActivado", 0);
        }

        if (Input.GetMouseButtonUp(0))
        {
            pe.enabled = false;
        }

    }

    void ventiladorActivado()
    {
        pe.enabled = true;
    }

 
}
