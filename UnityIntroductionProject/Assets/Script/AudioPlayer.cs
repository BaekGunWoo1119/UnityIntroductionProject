using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioPlayer : MonoBehaviour
{
    public AudioClip soundClip;

    private AudioSource audioSource;

    public void PlaySound()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(soundClip);
    }
}
