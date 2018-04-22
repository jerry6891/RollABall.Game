using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionSound : MonoBehaviour {

    public AudioSource conquest;

    public void Playconquest()
    {
        conquest.Play();
    }

	void Start()
	{
        // conquest.Play();
	}

	void Update()
	{
        // conquest.Play();
	}

	private void OnTransformChildrenChanged()
	{
        conquest.Play();
	}
}
