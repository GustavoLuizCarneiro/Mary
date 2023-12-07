using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
public class ShowFps : MonoBehaviour
{
    public Toggle checkBox;
    public static int fps_ = 0;

    private void Update()
    {
        if(checkBox.isOn)
        {
            fps_ = 1;
            PlayerPrefs.SetInt("fps_", fps_);
        }
        else 
        {
            fps_ = 0;
            PlayerPrefs.SetInt("fps_", fps_);
        }
    }
}
