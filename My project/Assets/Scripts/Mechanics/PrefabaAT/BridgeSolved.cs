using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class BridgeSolved : MonoBehaviour
{
    private GameObject BridgeTarget;
    private Animator BridgeAnim;
    private TextMeshProUGUI textBridge;

    void Start()
    {
        BridgeTarget = GameObject.Find("Target");
        BridgeAnim = BridgeTarget.GetComponent<Animator>();
        textBridge = GameObject.Find("FirstATM").GetComponent<TextMeshProUGUI>();

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out BridgeArea bridgearea))
        {
            textBridge.text = "Press (E) to open bridge.";
            BridgeAnim.SetTrigger("bridge");
        }
    }

}
