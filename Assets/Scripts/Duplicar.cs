using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Duplicar : MonoBehaviour
{
    GameObject pepeNuevo;
    public Transform puntoDuplicacion;

    public EfectosSonido efs;

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
        
        pepeNuevo = Instantiate(gameObject, puntoDuplicacion.transform.position, puntoDuplicacion.transform.rotation);
        efs.SonidoPepe();
    }

}
