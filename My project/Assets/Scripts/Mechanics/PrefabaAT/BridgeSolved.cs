using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class BridgeSolved : MonoBehaviour
{
    private Animation anim;
    private TextMeshProUGUI textBridge;

    void Start()
    {
        anim = GameObject.Find("Target").GetComponent<Animation>();
        textBridge = GameObject.Find("FirstATM").GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out BridgeArea bridgearea))
        {
            textBridge.text = "Bridge Opened...";
            //BridgeAnim.SetTrigger("bridge");
            anim.Play();
        }
    }

}
