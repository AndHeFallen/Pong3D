using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controls : MonoBehaviour
{
    public float velocity;

    private Rigidbody rbody;

    void Start() {
        rbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        float inputX = Input.GetAxisRaw("Horizontal");
        
        float moveX = inputX * velocity * Time.deltaTime;

        rbody.AddForce(moveX, 0f, 0f, ForceMode.Impulse);
    }
}