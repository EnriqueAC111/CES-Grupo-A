using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;


public class SoundController : MonoBehaviour
{

    public AudioMixer mixer;
    bool musicaActiva = true;
    bool sonidoActivo = true;

    public Image botonMusica;
    public Image botonEfectos;




    public Sprite EfectosNormal;
    public Sprite EfectosParada;

    public Sprite MusicaNormal;
    public Sprite MusicaParada;


    private static SoundController instance = null;
    public static SoundController Instance
    {
        get { return instance; }
    }
    /*
            // Esta función se ejecuta cuando se carga la escena.
        void Awake()
        {
                // Esta función verifica si existe un objeto con el mismo código en la escena. Si es así, destruye el elemento que acaba de crear, mientras que si no existe ningún elemento con el código, lo crea.
            if (instance != null && instance != this) { 
                Destroy(this.gameObject);   
                return;     
            } else {
                instance = this;
            }
            DontDestroyOnLoad(this.gameObject);
        }
        */





    // Este script será el que controle el sonido y la música. Se podrá mutear o desmutear cada uno en el menú de ajustes.
    public void Musica()
    {
        if (musicaActiva)
        {
            mixer.SetFloat("musica", -80f);     // Se pone la música suficientemente baja como para que no se oiga.
            botonMusica.sprite = MusicaParada;  // Se cambia el sprite del botón para que aparezca que no hay música.
            musicaActiva = false;               
        }else
        {
            mixer.SetFloat("musica", -15);      // Se ajustan los decibelios para que vuelva a sonar la música.
            botonMusica.sprite = MusicaNormal;  // Se devuelve el sprite del botón al de música activa.
            musicaActiva = true;
        }
    }


    public void Sonido()
    {
        if (sonidoActivo)
        {
            mixer.SetFloat("efectos", -80f);        // Se ponen los sonidos suficientemente baja como para que no se oiga.
            botonEfectos.sprite = EfectosParada;    // Se cambia el sprite del botón para que aparezca que no hay efectos de sonido.
            sonidoActivo = false;
        }
        else
        {
            mixer.SetFloat("efectos", -16);         // Se ajustan los decibelios para que vuelvan a sonar los efectos.
            botonEfectos.sprite = EfectosNormal;    // Se cambia el sprite del botón para que aparezca que hay efectos de sonido.
            sonidoActivo = true;
        }
    }

}