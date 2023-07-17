using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DartArrowInteract : MonoBehaviour
{
    private Animation anim;
    private Rigidbody arrowRb;
    [HideInInspector] public bool dartAndArrow = false;
    private void Start()
    {
        anim = GameObject.Find("Target").GetComponent<Animation>();
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out Arrow arrow))
        {
            anim.Play();
            arrowRb = arrow.gameObject.GetComponent<Rigidbody>();
            arrowRb.isKinematic = true;
            dartAndArrow = true;
        }
    }
}
