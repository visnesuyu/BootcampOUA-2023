using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationTriggered : MonoBehaviour
{
    GameObject Door;
    bool isOpen;
    void DoorOpen() { }
    private void Awake()
    {
        Door = transform.gameObject;
        isOpen = false;
    }
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if(gameObject.TryGetComponent(out AnimationTriggered ai))
        {
            isOpen = true;
            DoorOpen(isOpen);
        }
    }
    void DoorOpen(bool isOpen)
    {
        int counter = 0;
        if (isOpen && counter < 1)
        {
            Door.GetComponent<Animator>().Play(1);
            counter++;
        }
    }

}
