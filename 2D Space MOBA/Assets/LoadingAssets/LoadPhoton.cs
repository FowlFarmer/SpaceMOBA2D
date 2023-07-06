using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;
using UnityEngine.SceneManagement;
using Photon.Realtime;

public class LoadPhoton : MonoBehaviourPunCallbacks
{
    private bool fullscreen = false;
    private void Start()
    {
        Screen.SetResolution(1280, 720, fullscreen);
        print("Connecting to server");
        PhotonNetwork.ConnectUsingSettings(); //CHANGE LATER TO CONNECTREGION USA
        PhotonNetwork.GameVersion = "0.0.1";
    }


    public override void OnConnectedToMaster()
    {
        print("Connected to server");
        PhotonNetwork.JoinLobby();
    }
    public override void OnDisconnected(DisconnectCause cause)
    {
        print("Disconnected from server");
    }
    public override void OnJoinedLobby()
    {
        SceneManager.LoadScene("Lobby");
    }
}
