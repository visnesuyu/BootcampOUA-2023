using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public int damageAmount = 20;
    public static bool isDestroy = false;
    

    private void Start()
    {
        if (isDestroy)
        {
            Destroy(gameObject, 10);
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        Destroy(transform.GetComponent<Rigidbody>());
        if(other.tag == "Dragon")
        {
            other.GetComponent<Dragon>().TakeDamage(damageAmount);
        }
    }
}
