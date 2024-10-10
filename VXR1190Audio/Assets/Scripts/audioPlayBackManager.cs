using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioPlayBackManager : MonoBehaviour
{
    public AudioSource audioPlayer;
    //Custom function
    //Public means that you can access it in another script
    public void PlayAudio()
    {
        audioPlayer.Play();
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
