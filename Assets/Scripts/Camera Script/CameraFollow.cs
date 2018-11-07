﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour 
{

	private Transform player;

	void Awake()
	{
		player = GameObject.Find("Player").transform;
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (player != null)
		{
			Vector3 temp = transform.position;

			temp.x = player.position.x;
			temp.y = player.position.y + 3f;

			transform.position = temp;
		}		
	}
}
