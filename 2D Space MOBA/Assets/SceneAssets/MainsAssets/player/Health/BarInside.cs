using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class BarInside : MonoBehaviour
{
    PhotonView view;
    void Start()
    {
        view = GetComponent<PhotonView>();
    }
    void Update()
    {
        if (view.IsMine)
        {
            float PercentHP = (PlayerSpecs.CurrentHealth / PlayerSpecs.Health);
            if(PlayerSpecs.CurrentHealth <= 0) {
                GetComponent<SpriteRenderer>().enabled = false;
            }
            else
            {
                GetComponent<SpriteRenderer>().enabled = true;
                transform.localScale = new Vector3(PercentHP, 1f, 1f);
                float temp = (6.5f * PercentHP) - 6.5f;
                //Debug.Log(temp + " " + playerMovement.playerX + " " + PlayerSpecs.CurrentHealth + " "+PercentHP);
                transform.position = new Vector3(temp / 2 + playerMovement.playerX, playerMovement.playerY + 4, 0f);
                if (Input.GetKeyDown(KeyCode.O))
                {
                    PlayerSpecs.CurrentHealth -= 50;
                }
            }
        }
    }
}


