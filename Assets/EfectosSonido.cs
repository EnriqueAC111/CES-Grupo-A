using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;


public class EfectosSonido : MonoBehaviour
{

    AudioSource audioSource;

    public AudioClip sonidoRayo;
    public AudioClip sonidoBoton;
    public AudioClip sonidoBoomink;
    public AudioClip sonidoCasper;
    public AudioClip sonidoComerTuerca;
    public AudioClip sonidoKaze;
    public AudioClip sonidoPepe;
    public AudioClip sonidoVentilador;
    public AudioClip sonidoCes;



    private void Start()
    {
        
        audioSource = GetComponent<AudioSource>();

    }



    public void SonidoRayo()
    {
        audioSource.clip = sonidoRayo;
        audioSource.Play();
    }

    public void SonidoBoton()
    {
        audioSource.clip = sonidoBoton;
        audioSource.Play();
    }

    public void SonidoBoomink()
    {
        audioSource.clip = sonidoBoomink;
        audioSource.Play();
    }

    public void SonidoCasper()
    {
        audioSource.clip = sonidoCasper;
        audioSource.Play();
    }

    public void SonidoComerTuerca()
    {
        audioSource.clip = sonidoComerTuerca;
        audioSource.Play();
    }

    public void SonidoKaze()
    {
        audioSource.clip = sonidoKaze;
        audioSource.Play();
        Invoke("SonidoKaze", 1f);
    }

    public void SonidoPepe()
    {
        audioSource.clip = sonidoPepe;
        audioSource.Play();
    }

    public void SonidoVentilador()
    {
        audioSource.clip = sonidoVentilador;
        audioSource.Play();
    }

    public void SonidoCes()
    {
        audioSource.clip = sonidoCes;
        audioSource.Play();
    }



}
