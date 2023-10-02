using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    private AudioSource Ding;
    void Start()
    {
        Ding = GetComponent<AudioSource>();
    }
    public void PlayAudio1()
    {
        Ding.Play();
    }

}
