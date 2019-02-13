using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour
{
	public AudioClip coinSFX;

	AudioSource _audio;

	void Awake ()
	{
		_audio = GetComponent<AudioSource> ();
	}

	// Use this for initialization
	void Start ()
	{
		if (Door.instance != null)
		{
			Door.instance.countCollectables++; // incrementing collectables count 
		}
	}

	// play sound through the audiosource on the gameobject
	void PlaySound (AudioClip clip)
	{
		_audio.PlayOneShot(clip);
	}

	void OnTriggerEnter2D (Collider2D target)
	{
		if (target.tag == "Player")
		{
			PlaySound (coinSFX);
			Destroy (gameObject);

			if (Door.instance != null)
			{
				Door.instance.DecrementCollectables ();
			}
		}
	}
}