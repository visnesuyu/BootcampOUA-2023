using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject playerPrefabArcher;
    public GameObject canvasToDisable;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void CreateMage()
    {
        PhotonNetwork.Instantiate(playerPrefabArcher.name, new Vector3(60.53f, -0.3f, 0), Quaternion.identity);
        canvasToDisable.SetActive(false);

    }
    public void CreateArcher()
    {
        PhotonNetwork.Instantiate(playerPrefabArcher.name, new Vector3(60.53f, -0.3f, 0), Quaternion.identity);
        canvasToDisable.SetActive(false);
    }
}
