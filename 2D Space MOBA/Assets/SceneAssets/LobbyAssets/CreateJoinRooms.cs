using UnityEngine;
using UnityEngine.UI;
using Photon.Pun;

public class CreateJoinRooms : MonoBehaviourPunCallbacks
{
    public InputField Input;

    public void CreateRoom()
    {
        print(Input.text);
        PhotonNetwork.CreateRoom(Input.text);
    }
    public void JoinRoom()
    {
        print(Input.text);
        PhotonNetwork.JoinRoom(Input.text);
    }
    public override void OnJoinedRoom()
    {
        PhotonNetwork.LoadLevel("Mains");
    }

}
