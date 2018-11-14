﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AirAndTimer : MonoBehaviour
{

	void OnTriggerEnter2D (Collider2D target)
	{
		if (target.tag == "Player")
		{
			if (gameObject.name == "Air")
			{
				GameObject.Find ("GameplayController").GetComponent<AirTimer> ().air += 15f;
			}
			else
			{
				GameObject.Find ("GameplayController").GetComponent<LevelTimer> ().time += 15f;
			}

			Destroy(gameObject);
		}
	}
}