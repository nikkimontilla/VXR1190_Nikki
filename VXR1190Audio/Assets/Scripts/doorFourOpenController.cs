using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorFourOpenController : MonoBehaviour
{
    Animator _doorAnim;

    private void OnTriggerEnter(Collider other)
    {
        _doorAnim.SetBool("Door4", true);
    }

    /*private void OnTriggerExit(Collider other)
    {
        _doorAnim.SetBool("Door4", false);
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
