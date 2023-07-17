using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.UI;
public class SpawnPlayers : MonoBehaviour
{
    public GameObject playerPrefab;
    public GameObject playerPrefabArcher;
    //public GameObject canvasToDisable;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Startta bu hoca");
        Debug.Log(PhotonNetwork.CurrentRoom.PlayerCount);
        if (PhotonNetwork.CurrentRoom.PlayerCount == 1)
        {
            PhotonNetwork.Instantiate(playerPrefab.name, new Vector3(48.2f, 1.39f, -4.8f), Quaternion.identity);
        }
       else if(PhotonNetwork.CurrentRoom.PlayerCount != 1)
        {
            PhotonNetwork.Instantiate(playerPrefabArcher.name, new Vector3(48.2f, 1.39f, 6.56f), Quaternion.identity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(PhotonNetwork.CurrentRoom.PlayerCount);
    }
    public void CreateMage()
    {
        
       // canvasToDisable.SetActive(false);

    }
    public void CreateArcher()
    {
        
       // canvasToDisable.SetActive(false);
    }
}
