using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour {
    public AudioSource hit;

    public void Playhit()
    {
        hit.Play();
    }

    void OnTriggerEnter()
    {
        hit.Play();
    }
}
