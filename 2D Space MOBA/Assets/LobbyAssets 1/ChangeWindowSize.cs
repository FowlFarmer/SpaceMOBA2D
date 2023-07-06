using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWindowSize : MonoBehaviour
{
    private bool fullscreen = false;
    public void SmallSizeWindow()
    {
        Screen.SetResolution(1280, 720, fullscreen);
    }
    public void LargeSizeWindow()
    {
        Screen.SetResolution(1600, 900, fullscreen);
    }
}
