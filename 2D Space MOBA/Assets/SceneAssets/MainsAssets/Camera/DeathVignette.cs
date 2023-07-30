using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathVignette : MonoBehaviour
{
    void Update()
    {
        if(BarInside.IsDead == true)
        {
            GetComponent<SpriteRenderer>().enabled = true;
        }
        if (BarInside.IsDead == false)
        {
            GetComponent<SpriteRenderer>().enabled = false;
        }
    }
}
