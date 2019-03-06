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


    void Awake()
    {
        if (instance != null && instance != this) {
            Destroy(this.gameObject);
            return;
        } else {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    

    public void Musica()
    {
        if (musicaActiva)
        {
            mixer.SetFloat("musica", -80f);
            botonMusica.sprite = MusicaParada;
            musicaActiva = false;
        }else
        {
            mixer.SetFloat("musica", 0);
            botonMusica.sprite = MusicaNormal;
            musicaActiva = true;
        }
    }


    public void Sonido()
    {
        if (sonidoActivo)
        {
            mixer.SetFloat("efectos", -80f);
            botonEfectos.sprite = EfectosParada;
            sonidoActivo = false;
        }
        else
        {
            mixer.SetFloat("efectos", 0);
            botonEfectos.sprite = EfectosNormal;
            sonidoActivo = true;
        }
    }

}