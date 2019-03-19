using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoominkController : MonoBehaviour
{


    public GameObject tuerca;
    Rigidbody2D rbTuerca;
    Animator animator;
    public GameObject vortice;


    public float velocidad = 100f;  // Velocidad que tendrá la tuerca cuando salga disparada hacia arriba.

    public EfectosSonido efs;


    // Aqui se inicializan los elementos que van a ser necesarios para que el script funcione. Por ejemplo Rigidbody o Animator
    void Start()
    {
        rbTuerca = tuerca.GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
            // Aquí se define qué pasará cuando se cumplan dos variables: que el botón izquierdo del ratón sea pulsado y que la tuerca sea hija del elemento que tiene el código.
        if ((Input.GetMouseButtonDown(0)) && (tuerca.transform.IsChildOf(gameObject.transform))) 
        {
            transform.DetachChildren(); // Hace que la tuerca deje de ser hijo de Boomink.
            rbTuerca.isKinematic = false;   // Vuelven a afectarle fuerzas a la tuerca.
            rbTuerca.AddForce(transform.up * velocidad);    // La tuerca se lanza hacia arriba desde donde esté.
            animator.SetBool("Tocar", true);    // Se ejecuta una animación.
            efs.SonidoBoomink();    // Se ejecuta un efecto de sonido.


        }   // Aquí se define qué pasará cuando el botón izquierdo del ratón deje de estar presionado.
        if (Input.GetMouseButtonUp(0))
        {
            animator.SetBool("Tocar", false);
        }
    }

            
    private void OnCollisionEnter2D(Collision2D collision)
    {
            // Esta función hace que cuando el elemento que tiene el código choque contra un elemento con el tag "Tuerca" se ejecute a cabo la función
        if (collision.gameObject.CompareTag("Tuerca"))
        {
            collision.transform.SetParent(gameObject.transform);    // Convierte la tuerca en hijo de Boomink.
            tuerca.transform.position = Vector3.MoveTowards(tuerca.transform.position, vortice.transform.position, Time.deltaTime); // Actualiza la posición de la tuerca para que sea igual a la de Boomink.
            rbTuerca.isKinematic = true;    // Hace que dejen de afectarle fuerzas a la tuerca.
            
        }

    }



}
