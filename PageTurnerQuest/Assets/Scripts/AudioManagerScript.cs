using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManagerScript : MonoBehaviour
{
    [SerializeField] AudioSource musicSource;
    public AudioClip background;

    private void Start(){
        musicSource.clip = background;
        musicSource.Play();
    }

    private void Update(){
        if(!musicSource.isPlaying){
            musicSource.Play();
        }
    }

}
