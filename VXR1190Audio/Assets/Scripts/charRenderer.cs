using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class charRenderer : MonoBehaviour
{
    public GameObject character;

    // Start is called before the first frame update

    public void Start()
    {
        character.SetActive(false);
    }
    public void OnTriggerEnter(Collider other)
    {
        character.SetActive(true);
      
    }
    private void OnTriggerExit(Collider other)
    {
        character.SetActive(false);
    }
}
