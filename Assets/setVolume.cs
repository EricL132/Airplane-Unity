using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class setVolume : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource aud;
    void Awake(){
        aud.volume = optionVolume.musicv;
    }
}
