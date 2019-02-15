using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{

    public Canvas menuPausa;
    public Canvas hud;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void ReiniciarLvl()
    {
       
    }

    public void PantallaPausa()
    {
        menuPausa.enabled = true;
        hud.enabled = false;
        Time.timeScale = 0f;
    }

    public void ReanudarLvl()
    {
        hud.enabled = true;
        menuPausa.enabled = true;
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

    public void SeleccionNivel()
    {

        SceneManager.LoadScene("SeleccionNivel");
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

 
}
