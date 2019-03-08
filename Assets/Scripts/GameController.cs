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

   // string nivelCargado;


    // Start is called before the first frame update

    void Start()
    {
        
    }


    private void Awake()
    {
        nivelActual = SceneManager.GetActiveScene();
        menuPausa.SetActive(false);
    }


    // Update is called once per frame
    void Update()
    {
        if (tuerca == null)
        {
            Invoke("PantallaFinal", 3f);
        }
    }

    public void ReiniciarLvl()
    {
        SceneManager.LoadScene(nivelActual.name);
        Time.timeScale = 1f;

        hud.SetActive(true);
    }

    public void SiguienteLvl()
    {
        SceneManager.LoadScene(nivelActual.buildIndex + 1);
        Debug.Log(nivelActual.buildIndex);
    }

    public void PantallaPausa()
    {
        menuPausa.SetActive(true);
        hud.SetActive(false);
        Time.timeScale = 0f;
    }

    public void ReanudarLvl()
    {
        menuPausa.SetActive(false);
        hud.SetActive(true);
        Time.timeScale = 1f;

    }
    

    public void PantallaAjustes()
    {

        SceneManager.LoadScene("PantallaAjustes");
    }

    public void PantallaInfo()
    {

        SceneManager.LoadScene("PantallaInfo");
    }

    public void MenuInicial()
    {

        SceneManager.LoadScene("MenuInicio");
    }

    public void SeleccionMundo()
    {

        SceneManager.LoadScene("SeleccionMundo");
        Time.timeScale = 1f;
    }

    public void Nivel1()
    {
         SceneManager.LoadScene("Nivel 1");
    }

    public void Nivel2()
    {

        SceneManager.LoadScene("Nivel 2");
    }

    public void Nivel3()
    {

        SceneManager.LoadScene("Nivel 3");
    }

 



    void PantallaFinal()
    {
        pantallaFinalNivel.SetActive(true);
        hud.SetActive(false);
    }
}
