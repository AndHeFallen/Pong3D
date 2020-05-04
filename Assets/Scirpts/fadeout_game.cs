using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeout_game : MonoBehaviour
{
    public Image image;

    void Start()
    {
        image.canvasRenderer.SetAlpha(1.0f);
        fade_out();
    }

    void fade_out() {
        image.CrossFadeAlpha(0, 1, false);
    }
}
