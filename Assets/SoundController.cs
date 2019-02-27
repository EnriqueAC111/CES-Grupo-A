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



    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
       
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