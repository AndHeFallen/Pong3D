using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class fadeout : MonoBehaviour
{
    public Image Image;
    public Image bouton1;
    public Image bouton2;
    public Image bouton3;

    void Start()
    {
        Image.canvasRenderer.SetAlpha(1.0f);
        bouton1.canvasRenderer.SetAlpha(0.0f);
        bouton2.canvasRenderer.SetAlpha(0.0f);
        bouton3.canvasRenderer.SetAlpha(0.0f);
        fade_out();
    }

    void fade_out() {
        Image.CrossFadeAlpha(0, 1, false);
        bouton1.CrossFadeAlpha(1, 1, false);
        bouton2.CrossFadeAlpha(1, 1, false);
        bouton3.CrossFadeAlpha(1, 1, false);
    }
}
