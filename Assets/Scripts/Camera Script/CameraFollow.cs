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
		
	}
}
