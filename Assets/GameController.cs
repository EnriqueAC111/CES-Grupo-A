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



    public void CargaPlay()
    {
        SceneManager.LoadScene("Escena 1");
    }

    public void CargaAjustes()
    {
        SceneManager.LoadScene("PantallaAjustes");
    }

    public void CargaInfo()
    {
        SceneManager.LoadScene("PantallaInfo");
    }


}
