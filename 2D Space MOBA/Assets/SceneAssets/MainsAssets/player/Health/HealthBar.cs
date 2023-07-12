using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class HealthBar : MonoBehaviour
{
    PhotonView view;
    void Start()
    {
        view = GetComponent<PhotonView>();
        transform.parent = null;
    }

    void Update()
    {
        transform.position = new Vector3(playerMovement.playerX, playerMovement.playerY + 4, 0);
        transform.rotation = Quaternion.identity;
    }
}