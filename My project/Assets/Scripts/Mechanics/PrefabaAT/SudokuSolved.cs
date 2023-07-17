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
    private void Awake()
    {
        spawnPoints[0] = GameObject.Find("tp1");
        spawnPoints[1] = GameObject.Find("tp2");
    }
    private void Start()
    {
        player = transform.gameObject;
        canvas = GameObject.Find("FirstATM").GetComponent<TextMeshProUGUI>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.TryGetComponent(out Sudoku sudoku))
        {
            canvas.text = "The final is for two people.";
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
                whichPlayer = 0;
                checker++;
                isMagician = true;
            }
            else if (gameObject.TryGetComponent(out Okcu o))
            {
                whichPlayer = 1;
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
