using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightend : MonoBehaviour
{
    public Light myLight;
    
    private void Start() {
        myLight = GetComponent<Light> ();
        LightOff();
    }

    public void LightOn() {
        myLight.enabled = true;
    }
    public void LightOff() {
        myLight.enabled = false;
    }
}
