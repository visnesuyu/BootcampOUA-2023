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
    private InputAction interactAction;

    void Start()
    {
        BridgeTarget = GameObject.Find("Target");
        BridgeAnim = BridgeTarget.GetComponent<Animator>();
        textBridge = GameObject.Find("FirstATM").GetComponent<TextMeshProUGUI>();

        PlayerInput playerInput = GetComponent<PlayerInput>();
        interactAction = playerInput.actions.FindAction("Interact");
        interactAction.performed += OnInteract;

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out BridgeArea bridgearea))
        {
            textBridge.text = "Press (E) to open bridge.";
        }
    }

    private void OnInteract(InputAction.CallbackContext context)
    {
        if (context.performed)
        {
            // Code to execute when the "E" button is pressed.
            Debug.Log("Interact button (E) pressed!");
            BridgeAnim.SetTrigger("bridge");
        }
    }
    private void OnEnable()
    {
        // Enable the input action when the script is enabled.
        // Replace "PressE" with the name you gave to the input action.
        interactAction.Enable();
    }

    private void OnDisable()
    {
        // Disable the input action when the script is disabled.
        // Replace "PressE" with the name you gave to the input action.
        interactAction.Disable();
    }
}
