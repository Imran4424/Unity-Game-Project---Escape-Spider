using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AirTimer : MonoBehaviour 
{
	private Slider slider;

	private GameObject player;

	public float air = 100f;

	private float airBurn = 1f;

	void Awake()
	{
		GetReferences();
	}
	
	// Update is called once per frame
	void Update () 
	{
		if (!player)
		{
			return;
		}

		if (air > 0)
		{
			air -= airBurn * Time.deltaTime;

			slider.value = air;
		}
		else
		{
			Destroy(player);
			GetComponent<GameplayController>().PlayerDied();
		}
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
