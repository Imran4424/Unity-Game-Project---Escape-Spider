﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderJumper : MonoBehaviour
{

	private float forceY;
	private Rigidbody2D myBody;
	private Animator anim;

	void Awake ()
	{
		myBody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	// Use this for initialization
	void Start ()
	{
		StartCoroutine (Attack ());
	}

	IEnumerator Attack ()
	{
		yield return new WaitForSeconds (Random.Range (0, 7));

		forceY = Random.Range (250, 550);

		myBody.AddForce (new Vector2 (0, forceY));
		anim.SetBool ("Attack", true);

		yield return new WaitForSeconds (.7f);

		StartCoroutine (Attack ());
	}

	void OnTriggerEnter2D (Collider2D target)
	{
		if (target.tag == "Ground")
		{
			anim.SetBool ("Attack", false);
		}

		if (target.tag == "Player")
		{
			Destroy (target.gameObject);
			GameObject.Find ("Gameplay Controller").GetComponent<GameplayController> ().PlayerDied ();
		}
	}
}