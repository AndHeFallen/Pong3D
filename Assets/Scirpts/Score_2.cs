using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score_2 : MonoBehaviour
{

    private Ball ball;
    private TextMesh t;

    public string text_j2;

    void Start()
    {
        ball = GameObject.Find("Ball").GetComponent<Ball>();
        t = (TextMesh)gameObject.GetComponent(typeof(TextMesh));
    }
    
    void Update()
    {
        t.text = text_j2;
    }
}
