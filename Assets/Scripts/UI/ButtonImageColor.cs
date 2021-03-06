﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonImageColor : MonoBehaviour
{
    public float fadeTime = 0.1f;
    public Button buttonToColor;

    private bool toggled = false;

    public void Toggle(Button button, Color toggleColor)
    {
        MaskableGraphic foregroundImage = button.GetComponent<Image>();

        if (!toggled)
        {
            foregroundImage.CrossFadeColor(toggleColor, fadeTime * 1.2f, false, true);
            button.GetComponent<ButtonImageColor>().toggled = true;
        }
        else if (toggled)
        {
            foregroundImage.CrossFadeColor(Color.white, fadeTime * 1.2f, false, true);
            button.GetComponent<ButtonImageColor>().toggled = false;
        }
    }

    public bool ToggleStatus()
    {
        return toggled;
    }
}