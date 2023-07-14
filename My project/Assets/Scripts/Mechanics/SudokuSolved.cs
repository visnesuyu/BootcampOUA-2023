using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SudokuSolved : MonoBehaviour
{
    bool sudokuSolved = false;
    [SerializeField] GameObject player;
    [SerializeField] GameObject[] spawnPoints = new GameObject[2];

    private void OnTriggerEnter(Collider other)
    {

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
            }
            else if (gameObject.TryGetComponent(out Okcu o))
            {
                whichPlayer = 2;
            }
            else
            {
                throw new Exception("invalid player");
            }
            GameObject TP = spawnPoints[whichPlayer];
            player.transform.position =
            new Vector3(TP.transform.position.x,
            TP.transform.position.y + 1,
            TP.transform.position.z);
        }
    }
}
