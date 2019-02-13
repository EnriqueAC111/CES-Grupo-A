using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{



    public static GameController instance;

    string PantallaAnterior = "";
    Scene scene;





    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Awake()
    {
        //If we don't currently have a game control...
        if (instance == null)
            //...set this one to be it...
            instance = this;
        //...otherwise...
        else if (instance != this)
            //...destroy this one because it is a duplicate.
            Destroy(gameObject);
    }




    // Update is called once per frame
    void Update()
    {

    }
    

    public void PantallaAjustes()
    {
        scene = SceneManager.GetActiveScene();
        PantallaAnterior = scene.name;

        Debug.Log(PantallaAnterior);
        SceneManager.LoadScene("PantallaAjustes");
    }

    public void PantallaInfo()
    {
        scene = SceneManager.GetActiveScene();
        PantallaAnterior = scene.name;

        Debug.Log(PantallaAnterior);
        SceneManager.LoadScene("PantallaInfo");
    }

    public void MenuInicial()
    {
        scene = SceneManager.GetActiveScene();
        PantallaAnterior = scene.name;

        Debug.Log(PantallaAnterior);
        SceneManager.LoadScene("MenuInicio");
    }

    public void SeleccionNivel()
    {
        scene = SceneManager.GetActiveScene();
        PantallaAnterior = scene.name;

        Debug.Log(PantallaAnterior);
        SceneManager.LoadScene("SeleccionNivel");
    }

    public void Nivel1()
    {
        scene = SceneManager.GetActiveScene();
        PantallaAnterior = scene.name;

        Debug.Log(PantallaAnterior);
        SceneManager.LoadScene("Nivel 1");
    }

    public void Nivel2()
    {
        scene = SceneManager.GetActiveScene();
        PantallaAnterior = scene.name;

        Debug.Log(PantallaAnterior);
        SceneManager.LoadScene("Nivel 2");
    }

    public void Nivel3()
    {
        scene = SceneManager.GetActiveScene();
        PantallaAnterior = scene.name;

        Debug.Log(PantallaAnterior);
        SceneManager.LoadScene("Nivel 3");
    }

    public void Volver()
    {
        SceneManager.LoadScene(PantallaAnterior);
    }


}
