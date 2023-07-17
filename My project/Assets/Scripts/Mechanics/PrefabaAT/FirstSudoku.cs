using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.InputSystem;

public class FirstSudoku : MonoBehaviour
{
    private TextMeshProUGUI canvas;
    private Animator animator;
    private Animator animator2;
    private Animator Selectedanim;
    private int Timer;

    private void Start()
    {
        canvas = GameObject.Find("FirstATM").GetComponent<TextMeshProUGUI>();
        animator = GameObject.Find("door1anim").GetComponent<Animator>();
        animator2 = GameObject.Find("door2anim").GetComponent<Animator>();
        if(transform.gameObject == transform.gameObject.TryGetComponent(out Buyucu b))
        {
            Selectedanim = animator;
        }
        else
        {
            Selectedanim = animator2;
        }
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
            Selectedanim.SetTrigger("open");
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
