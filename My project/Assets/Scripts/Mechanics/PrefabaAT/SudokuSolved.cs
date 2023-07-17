using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SudokuSolved : MonoBehaviour
{
    GameObject player;
    GameObject[] spawnPoints = new GameObject[2];
    TextMeshProUGUI canvas;
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
            Teleport();        
        }
    }
    private void Update()
    {
    }

    void WhichCharacter()
    {
        if(player = GameObject.Find("Archer 1"))
        {
            isArcher = true;
        }
        else
        {
            isMagician = true;
        }
    }
    void Teleport()
    {
        WhichCharacter();
        if (isArcher)
        {
            player.transform.position = new Vector3(spawnPoints[0].transform.position.x,
                spawnPoints[0].transform.position.y + 1,
                spawnPoints[0].transform.position.z
                );
        }
        else
        {
            player.transform.position = new Vector3(
                spawnPoints[1].transform.position.x,
                spawnPoints[1].transform.position.y + 1,
                spawnPoints[1].transform.position.z);
        }
    }
    }
