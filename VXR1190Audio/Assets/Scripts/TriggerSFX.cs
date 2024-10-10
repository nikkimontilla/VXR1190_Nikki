using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerSFX : MonoBehaviour
{
    public AudioSource playSound;

    private void OnTriggerEnter(Collider other)
    {
        
    }
    // Start is called before the first frame update
    void Start()
    {
        playSound.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
