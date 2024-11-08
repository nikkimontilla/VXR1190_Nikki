using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorOneOpenController : MonoBehaviour
{
    Animator _doorAnim;

    private void OnTriggerEnter(Collider other)
    {
        _doorAnim.SetBool("isOpening", true);
    }

    /*private void OnTriggerExit(Collider other)
    {
        _doorAnim.SetBool("isOpening", false);
    }
    */
    private void Start()
    {
        _doorAnim = this.transform.parent.GetComponent<Animator>();
    }

    private void Update()
    {
        
    }
}
