using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public GameObject menuPausa;
    public GameObject hud;
    public GameObject pantallaFinalNivel;
    public GameObject tuerca;




    Scene nivelActual;


        // Esta función se ejecuta cuando se carga la escena.
    private void Awake()
    {
        nivelActual = SceneManager.GetActiveScene();    // Guarda la escena actual
        menuPausa.SetActive(false);     // Para evitar bugs se oculta el menu de pausa aunque esté desactivado de serie.
    }


    // Update is called once per frame
    void Update()
    {
            // Si no existe el elemento tuerca, es decir si CES se la ha comido, aparecerá la pantalla de final de nivel.
        if (tuerca == null)
        {
            Invoke("PantallaFinal", 3f);
        }
    }


        // Es la función que se ejecuta cuando se pulsa el botón de reinicio de nivel.
    public void ReiniciarLvl()
    {
        SceneManager.LoadScene(nivelActual.name);   // Carga la escena actual de nuevo.
        Time.timeScale = 1f;    // Devuelve el flujo de tiempo a su normalidad, para que no esté todo parado.

        hud.SetActive(true);    // Activa el HUD.
    }


        // Es la función que se ejecuta cuando se pulsa el botón para ir al siguiente nivel.
    public void SiguienteLvl()
    {
        SceneManager.LoadScene(nivelActual.buildIndex + 1); // Suma uno al index del nivel actual y carga el número de pantalla que se consiga con la suma.

    }


        // Es la función que se ejecuta cuando se pulsa el botón de pausa.
    public void PantallaPausa()
    {
        menuPausa.SetActive(true);  // Hace que aparezca el menú de pausa.
        hud.SetActive(false);   // Oculta el HUD mientras esté activa la pantalla de pausa.
        Time.timeScale = 0f;    // Hace que se paren todos los elementos que haya en pantalla.
    }


        // Es la función que se ejecuta cuando se pulsa el botón de continuar jugando en el mismo nivel.
    public void ReanudarLvl()
    {
        menuPausa.SetActive(false); // Hace que se oculte el menú de pausa.
        hud.SetActive(true);    // Hace que aparezca de nuevo el HUD.
        Time.timeScale = 1f;    // Devuelve el flujo de tiempo a su normalidad, para que no esté todo parado.

    }


        // La función carga la escena predefinida como "PantallaAjustes".
    public void PantallaAjustes()
    {
            
        SceneManager.LoadScene("PantallaAjustes");
    }


        // La función carga la escena predefinida como "PantallaInfo".
    public void PantallaInfo()
    {
            
        SceneManager.LoadScene("PantallaInfo");
    }


        // La función carga la escena predefinida como "MenuInicio".
    public void MenuInicial()
    {

        SceneManager.LoadScene("MenuInicio");
    }


        // La función carga la escena predefinida como "SeleccionMundo". Además, para evitar bugs se pone que el tiempo sea el normal, por si se llega a esta pantalla desde el menú de pausa, en la que el tiempo está parado.
    public void SeleccionMundo()
    {

        SceneManager.LoadScene("SeleccionMundo");
        Time.timeScale = 1f;
    }


        // La función carga la escena predefinida como "Nivel 1".
    public void Nivel1()
    {
         SceneManager.LoadScene("Nivel 1");
    }


        // La función carga la escena predefinida como "Nivel 2".
    public void Nivel2()
    {

        SceneManager.LoadScene("Nivel 2");
    }


        // La función carga la escena predefinida como "Nivel 3".
    public void Nivel3()
    {

        SceneManager.LoadScene("Nivel 3");
    }




        // La función hace que aparezca el menú de la pantalla final y que desaparezca el HUD.
    void PantallaFinal()
    {
        pantallaFinalNivel.SetActive(true);
        hud.SetActive(false);
    }
}
