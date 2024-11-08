using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
    public AudioSource playSound;

    public void Awake()
    {
        playSound = GetComponent<AudioSource>();
    }

    public void OnTriggerEnter(Collider other)
    {
        playSound.Play();
    }

    public void OnTriggerExit(Collider other)
    {
        playSound.Stop();
    }

}
