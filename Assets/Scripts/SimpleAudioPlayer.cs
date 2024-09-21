using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SimpleAudioPlayer : MonoBehaviour
{
    public AudioSource audioSource;  // Reference to the AudioSource component

    void Start()
    {
        // Play the audio when the game starts
        PlayAudio();
    }

    // Function to play the audio
    public void PlayAudio()
    {
        if (audioSource != null)
        {
            audioSource.Play();
        }
        else
        {
            Debug.LogWarning("AudioSource not set!");
        }
    }
}
