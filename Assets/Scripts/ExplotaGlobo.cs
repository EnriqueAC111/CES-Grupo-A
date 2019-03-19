using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplotaGlobo : MonoBehaviour
{
    //Creamos en público las clases de "sistema de partículas" y "game object" que más tarde vincularemos en el inspector de Unity
    public ParticleSystem particulas;
    public GameObject particles;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //Creamos una función de "OnMouseDown" que al "clickar" que sobre el game object poseedor de este script
    //hará lo siguente: generar (mediante "Instantiate") el sistema de particulas nombrado y creado al principio
    //de este script, destruir este game object (globo) y activar el sistema de particulas recién referido
    void OnMouseDown()
    {
        Instantiate(particles, transform.position, transform.rotation);
        Destroy(gameObject);  
        particulas.Play();
    } 
}
