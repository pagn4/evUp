using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class optionSc : MonoBehaviour
{
    public AudioMixer audio;
    public void Volume(float vol){
        audio.SetFloat("volume", vol);
    }
}
