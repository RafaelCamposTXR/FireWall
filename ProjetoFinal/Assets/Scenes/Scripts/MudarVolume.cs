using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class MudarVolume : MonoBehaviour
{
    public AudioMixer audioMixer;

    public void SetarVolume(float volume)
    {
        audioMixer.SetFloat("volume", volume);
    }
}
