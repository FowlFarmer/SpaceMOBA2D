using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Photon.Pun;

public class BarInside : MonoBehaviour
{
    public static bool IsDead = false;
    public static int DeathTimerLength = 30;
    public static int DeathTimerCurrentLength = DeathTimerLength;
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
            if(PlayerSpecs.CurrentHealth <= 0 && IsDead == false) {
                GetComponent<SpriteRenderer>().enabled = false;
                IsDead = true;
                StartCoroutine(DeathTimer(DeathTimerLength));
            }
            else
            {
                GetComponent<SpriteRenderer>().enabled = true;
                transform.localScale = new Vector3(PercentHP, 1f, 1f);
                float temp = (6.5f * PercentHP) - 6.5f;
                //Debug.Log(temp + " " + playerMovement.playerX + " " + PlayerSpecs.CurrentHealth + " "+PercentHP);
                transform.position = new Vector3(temp / 2 + playerMovement.playerX, playerMovement.playerY + 4, 0f);
                if (Input.GetKeyDown(KeyCode.O)) //DEBUGGING TOOL NO WAY PUT THIS IN ACTUAL GAME
                {
                    PlayerSpecs.CurrentHealth -= 50;
                }
            }
        }
    }
    private System.Collections.IEnumerator DeathTimer(int seconds)
    {
        while (seconds > 0)
        {
            yield return new WaitForSeconds(1f);
            seconds--;
            DeathTimerCurrentLength--;
        }
        PlayerSpecs.CurrentHealth = PlayerSpecs.Health; //putting this before isdead=false to be safe?
        IsDead = false;
        DeathTimerCurrentLength = DeathTimerLength;
        Debug.Log("Death timer finished");
    }
}


