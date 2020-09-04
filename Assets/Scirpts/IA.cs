using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IA : MonoBehaviour
{
    private Ball ball ;
    private Rigidbody rbody;
    private float pos_x;
    private float pos_x_ball;

    public float diffup = 0;
    public float velocity;

    void Start()
    {
        ball = GameObject.Find("Ball").GetComponent<Ball>();
        rbody = GetComponent<Rigidbody>();
    }

    void Update()
    {
        pos_x = transform.position.x;

        pos_x_ball = ball.position_x;

        float ball_velocity = ball.velocity;

        if (pos_x_ball > pos_x) {
            rbody.AddForce(velocity * Time.deltaTime, 0f, 0f, ForceMode.Impulse);
        }
        if (pos_x_ball < pos_x) {
            rbody.AddForce((velocity - (2 * velocity)) * Time.deltaTime, 0f, 0f, ForceMode.Impulse);
        }

        if (ball_velocity > 20 && diffup == 0) {
            diffup = 1;
            velocity += 100;
        }
        if (ball_velocity > 25 && diffup == 1) {
            diffup = 2;
            velocity += 100;
        }
        if (ball_velocity > 30 && diffup == 2) {
            diffup = 3;
            velocity += 100;
        }
    }
}
