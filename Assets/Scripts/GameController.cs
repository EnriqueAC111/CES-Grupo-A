using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

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
