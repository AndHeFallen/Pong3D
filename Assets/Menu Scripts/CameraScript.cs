using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraScript : MonoBehaviour
{
    private float velocity;
    public float velocity2;
    private float movement;

    void Start() {
        velocity = 80f;
        velocity2 = 2f;
    }
    void Update(){
        Cursor.visible = true;
        if (velocity != 0f) {
            movement = velocity * Time.deltaTime;
            transform.Translate(0f, movement/3.7f, movement);
            velocity -= 1f;
        }
    }
}
