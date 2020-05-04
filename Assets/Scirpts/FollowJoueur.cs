using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowJoueur : MonoBehaviour
{
    public GameObject thePlayer;
    
    void Update()
    {
        transform.LookAt(thePlayer.transform);
    }
}
