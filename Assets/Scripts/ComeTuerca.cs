using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ComeTuerca : MonoBehaviour
{
    //Llamamos a todas aquellos componentes/clases que interferirán en el funcionamiento de esta mecánica/animación (tanto propias del Game Object poseedor de este script como externas)
    Animator anim;
    public GameObject tuerca;
    Rigidbody2D rb;
    public Collider2D cuerpo;

    public EfectosSonido efs;

    // Start is called before the first frame update
    void Start()
    {
        //Inicializamos los componentes de este game object
        anim = GetComponent<Animator>();
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {

    }
    //Creamos una función "OnTriggerEnter" que detectará cuando entrará en el trigger de nuestro game object (CES) cierto elemento
	void OnTriggerEnter2D (Collider2D other)
	{
        //Añadimos la condición de que, si el game object que se introduce en el trigger de nuestro game object (CES) tiene la etiqueta de "Tuerca", ocurre lo siguiente: el collider del cuerpo de CES se desactiva,
        //permitiendo que la tuerca lo atraviese (que será útil más adelante), el rigidbody de CES pase a ser estático (impidiendo que la animación provoque que caiga), se active la animación correspondiente (comer),
        //destruyendo el objecto intruso (tuerca) y se reproduzca el efecto de sonido correspondiente (sonido de comer)
        if (other.gameObject.CompareTag("Tuerca"))
        {
            cuerpo.enabled = false;
            rb.bodyType = RigidbodyType2D.Static;
            anim.SetBool("Comer", true);
            Destroy(other.gameObject);
            efs.SonidoCes();
        }
	}
    //Creamos una función "OnTriggerStay" que hará que mientras la tuerca permanezca en el trigger se redirija hacia el centro del game object (boca)
    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Tuerca"))
        {
            tuerca.transform.position = Vector3.MoveTowards(tuerca.transform.position, gameObject.transform.position, Time.deltaTime);
           
        }
    }
       

}
