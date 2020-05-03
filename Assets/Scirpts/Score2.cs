using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Score2 : MonoBehaviour
{

    private Ball ball2;
    private TextMesh t2;

    public string text_j2;

    void Start()
    {
        ball2 = GameObject.Find("Ball").GetComponent<Ball>();
        t2 = (TextMesh)gameObject.GetComponent(typeof(TextMesh));
    }
    
    void Update()
    {
        t2.text = text_j2;
    }
}
