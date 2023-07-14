using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharControls : MonoBehaviour
{   void Update()
    {
        if (Input.GetKeyDown("A"))
        {
            transform.position += new Vector3(0.1f,0,0);
        }
        if (Input.GetKeyDown("D"))
        {
            transform.position += new Vector3(-0.1f, 0, 0);
        }
        if (Input.GetKeyDown("W"))
        {
            transform.position += new Vector3(0f, 0.1f, 0);
        }
        if (Input.GetKeyDown("W"))
        {
            transform.position += new Vector3(0f, -0.1f, 0);
        }
    }
}
