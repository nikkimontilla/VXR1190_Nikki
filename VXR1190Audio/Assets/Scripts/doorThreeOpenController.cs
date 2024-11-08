using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorThreeOpenController : MonoBehaviour
{
    Animator _doorAnim;

    private void OnTriggerEnter(Collider other)
    {
        _doorAnim.SetBool("Door3_Opening", true);
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
