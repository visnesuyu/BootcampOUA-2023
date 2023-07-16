using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ArenaWait : MonoBehaviour
{
    enum tp
    {
        tp1,tp2
    }
    float timer = 5000;
    bool inArea = false;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out Buyucu v))
        {
            if(other.gameObject.TryGetComponent(out Okcu o))
            {
                inArea = true;
            }
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.TryGetComponent(out Buyucu v))
        {
            if (other.gameObject.TryGetComponent(out Okcu o))
            {
                inArea = false;
            }
        }
    }
    private void Update()
    {
        if (inArea)
        {
            timer = timer - Time.time;
            tp x = new tp();
            if (timer < 0)
            {
                gameObject.transform.position = GameObject.Find(x.ToString()).transform.position;
            }
        }
    }
}
