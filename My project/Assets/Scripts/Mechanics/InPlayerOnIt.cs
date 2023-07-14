using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;

public class InPlayerOnIt : MonoBehaviour
{
    public GameObject sudoku;
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out Player pl))
        {
            sudoku.SetActive(true);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if(other.gameObject.TryGetComponent(out Player pl))
        {
            sudoku.SetActive(false);
        }
    }
}
