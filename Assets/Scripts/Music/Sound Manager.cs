using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    //Estas serian las fuentes de Audio
    [SerializeField]public AudioSource Music;
    [SerializeField]public AudioSource Effects;

    //Estos son los ScrollBar, para controlar el volumen de ambas fuentes
    [SerializeField] public Scrollbar MusicSlider;
    [SerializeField] public Scrollbar EffectsSlider;

    //Aqui irian las musicas de fondo
    public AudioClip BackGround;
    //Aqui irian los clips
    public AudioClip ClickSound;

    void Start()
    {
        Music.clip = BackGround;

        PlayMusic("background");
    }
    public void PlayFX(string sound)
    {//Este metodo se encarga de producir en la fuente FX( Efectos) el sonido que se ordene
        if(sound == "click")
            Effects.PlayOneShot(ClickSound);
        //...
    }
    public void PlayMusic(string sound)
    {
        if(sound == "background")
            Music.clip = BackGround;
        Music.Play();
    }

    public void ChangingVolume(string source)
    {
        if(source == "Music")
            Music.volume= MusicSlider.value;
        else if(source == "Effects")
            Effects.volume= EffectsSlider.value;
    }



    
}
