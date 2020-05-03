using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour
{
    public void Teleport() {
        transform.position = new Vector3(-70f, 30f, 0f);
        transform.localEulerAngles =new Vector3(90f, 0f, 0f);
    }
}
