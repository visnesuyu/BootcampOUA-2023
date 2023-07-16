using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SudokuSolved : MonoBehaviour
{
    bool sudokuSolved = false;
    [SerializeField] GameObject player;
    [SerializeField] GameObject[] spawnPoints = new GameObject[2];
    [SerializeField] TextMeshProUGUI canvas;
    private int checker = 0;
    private bool isMagician, isArcher = false;

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out Sudoku sudoku))
        {
            canvas.text = "Press (E) to start solve puzzle";
        }
    }
    private void Update()
    {
        SudokuChecker(sudokuSolved);
    }
    void SudokuChecker(bool sudokusolved)
    {

        if (sudokusolved)
        {
            int whichPlayer;
            if (gameObject.TryGetComponent(out Buyucu b))
            {
                whichPlayer = 1;
                checker++;
                isMagician = true;
            }
            else if (gameObject.TryGetComponent(out Okcu o))
            {
                whichPlayer = 2;
                checker++;
                isArcher = true;
            }
            else
            {
                throw new Exception("invalid player");
            }
            if (isMagician && isArcher)
            {
                GameObject TP = spawnPoints[whichPlayer];
                player.transform.position =
                new Vector3(TP.transform.position.x,
                TP.transform.position.y + 1,
                TP.transform.position.z);
            }
        }
    }
}
