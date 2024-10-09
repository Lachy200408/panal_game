using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class SoundManager : MonoBehaviour
{
    [SerializeField]public AudioSource Music;
    [SerializeField]public AudioSource Effects;

    [SerializeField] public Slider MusicSlider;
    [SerializeField] public Slider EffectsSlider;

    public AudioClip BackGround;
    public AudioClip ClickSound;

    void Start()
    {
        Music.clip = BackGround;
        Music.Play();
    }
    public void PlayClick()
    {
        Effects.PlayOneShot(ClickSound);
    }
    

    
}
