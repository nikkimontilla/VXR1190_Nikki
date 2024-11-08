using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;


public class playBackManager : MonoBehaviour
{
    
    public AudioMixerSnapshot OminousAtmosphere;
    public AudioMixerSnapshot HorrorAmbience;

    public void OnTriggerEnter(Collider collision)
    {
        HorrorAmbience.TransitionTo(1);

    }

    public void OnTriggerExit(Collider collision)
    {
        OminousAtmosphere.TransitionTo(1);

    }
}
