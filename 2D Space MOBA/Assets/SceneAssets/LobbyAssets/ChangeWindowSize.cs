using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeWindowSize : MonoBehaviour
{
    public void SmallSizeWindow()
    {
        Screen.SetResolution(1280, 720, false);
    }
    public void LargeSizeWindow()
    {
        Screen.SetResolution(1600, 900, false);
    }
    public void FullscreenWindow()
    {
        Screen.SetResolution(1920, 1080, true);
    }
}
