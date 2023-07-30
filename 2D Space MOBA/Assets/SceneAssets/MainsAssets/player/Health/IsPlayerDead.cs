using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IsPlayerDead : MonoBehaviour
{
    void Update()
    {
        if(BarInside.IsDead == true)
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
        if (BarInside.IsDead == false)
        {
            GetComponent<SpriteRenderer>().enabled = true;
        }
    }
}
