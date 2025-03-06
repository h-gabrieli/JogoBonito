using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GerenciadorAudio : MonoBehaviour
{
    // Variaveis                     
    public AudioSource sound;
    public static GerenciadorAudio musica = null;



    // Funções    

    void Awake()
    {
        if( musica == null )
        {
            musica = this;
        }
        else
        {
            Destroy(musica);
        }
    }
    public void PlayA(AudioClip som)
    {
        sound.clip = som;
        sound.Play();
    }

}
