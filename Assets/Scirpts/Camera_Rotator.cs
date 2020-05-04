using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_Rotator : MonoBehaviour
{

    public float velocity;
    private float movement;

    void Start() {
         velocity = 5f;   
    }

    void Update()
    {
        movement = velocity * Time.deltaTime;
        transform.Rotate(0f, movement, 0f);
    }
}
