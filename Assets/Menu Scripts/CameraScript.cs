using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private float velocity;
    private float movement;

    void Start() {
        velocity = 80f;
    }
    void Update(){
        if (velocity != 0f) {
            movement = velocity * Time.deltaTime;
            transform.Translate(0f, movement/3.7f, movement);
            velocity -= 1f;
        }
    }
}
