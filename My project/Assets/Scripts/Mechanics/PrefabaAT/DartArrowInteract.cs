using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartArrowInteract : MonoBehaviour
{
    private Rigidbody arrowRb;
    [HideInInspector] public bool dartAndArrow = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out Arrow arrow))
        {
            arrowRb = arrow.gameObject.GetComponent<Rigidbody>();
            arrowRb.isKinematic = true;
            dartAndArrow = true;
        }
    }
}
