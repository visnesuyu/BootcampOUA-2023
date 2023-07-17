using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class FirstSudoku : MonoBehaviour
{
    private TextMeshProUGUI canvas;
    private Animation animator;
    private Animation animator2;
    private Animation Selectedanim;
    private int Timer;

    private void Start()
    {
        canvas = GameObject.Find("FirstATM").GetComponent<TextMeshProUGUI>();
        animator = GameObject.Find("door1anim").GetComponent<Animation>();
        animator2 = GameObject.Find("door2anim").GetComponent<Animation>();
        Timer = 5;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.TryGetComponent(out BlueATM blue))
        {
            canvas.text = "Blue ATM interact (E)";
        }
        else if (other.gameObject.TryGetComponent(out BeigeATM beige))
        {
            canvas.text = "Beige ATM interact (E)";
        }else if (other.gameObject.TryGetComponent(out CyanATM cyan))
        {
            canvas.text = "Cyan ATM interact (E)";
        }else if (other.gameObject.TryGetComponent(out GrayATM gray))
        {
            canvas.text = "Gray ATM interact (E)";
        }else if (other.gameObject.TryGetComponent(out GreenATM green))
        {
            canvas.text = "Green ATM interact (E)";
            animator.Play(); animator2.Play();
        }else if (other.gameObject.TryGetComponent(out OrangeATM orange))
        {
            canvas.text = "Orange ATM interact (E)";
        }else if (other.gameObject.TryGetComponent(out PinkATM pink))
        {
            canvas.text = "Pink ATM interact (E)";
        }else if (other.gameObject.TryGetComponent(out PurpleATM purple))
        {
            canvas.text = "Purple ATM interact (E)";
        }else if (other.gameObject.TryGetComponent(out YellowATM yellow))
        {
            canvas.text = "Yellow ATM interact (E)";
        }
    }
}
