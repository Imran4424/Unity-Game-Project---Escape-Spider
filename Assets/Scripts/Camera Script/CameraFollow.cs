﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour 
{

	private Transform player;

	private float minX = -24f, maxX = 267f, minY = -5.5f, maxY = 13f;

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

			if (temp.x < minX)
			{
				temp.x = minX;		
			}

			if (temp.x > maxX)
			{
				temp.x = maxX;
			}

			temp.y = player.position.y + 2f;

			if (temp.y < minY)
			{
				temp.y = minY;
			}

			if (temp.y > maxY)
			{
				temp.y = maxY;
			}

			transform.position = temp;
		}		
	}
}
