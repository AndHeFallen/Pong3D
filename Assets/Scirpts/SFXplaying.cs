using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SFXplaying : MonoBehaviour
{
    public AudioSource Ping;
    public AudioSource Pong;
    public AudioSource Lose;

    public void PlayPing() {
        Ping.Play();
    }

    public void PlayPong() {
        Pong.Play();
    }

    public void PlayLose() {
        Lose.Play();
    }
}
