using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirTimer : MonoBehaviour 
{
	private Slider slider;

	private GameObject player;

	private float air = 10f;

	private float airBurn = 1f;

	void Awake()
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void GetReferences()
	{
		player = GameObject.Find("Player");

		slider = GameObject.Find("Air Slider").GetComponent<Slider>();

		slider.minValue = 0f;
		slider.maxValue = air;
		slider.value = slider.maxValue;
	}
}
