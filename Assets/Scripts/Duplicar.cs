using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicar : MonoBehaviour
{

    public Transform puntoDuplicacion;
    public GameObject pepe;
   

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        GameObject pepeNuevo;
        pepeNuevo = Instantiate(gameObject, puntoDuplicacion.transform.position, puntoDuplicacion.transform.rotation);
    }

}
