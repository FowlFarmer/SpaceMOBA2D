using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class RespawnDisplay : MonoBehaviour
{
    void Update()
    {
        if (BarInside.IsDead == true)
        {
            GetComponent<Text>().enabled = true;
            string pointer = "Respawning - " + $"{BarInside.DeathTimerCurrentLength}";
            GetComponent<Text>().text = pointer;
            Debug.Log(pointer);
        }
        if (BarInside.IsDead == false)
        {
            GetComponent<Text>().enabled = false;
        }

    }
}
