using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interaction : MonoBehaviour
{
    bool isItTriggered;
    
    // Start is called before the first frame update
    void Start()
    {
       
    }

    
    private void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player"))
        { 
        isItTriggered = true;
            Debug.Log("trigger olmak ben");
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            isItTriggered = false;
        }
    }
    public bool GetBoolValue()
    {
        return isItTriggered;
    }
}
