using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class optionVolume : MonoBehaviour
{
   public AudioSource aud;
   public static float musicv = .25f;
   void Update(){
       aud.volume=musicv;
   }
    void Start(){
    }

   public void updateVolume(float volume){
       musicv = volume;
   }
}
