using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiamondScript : MonoBehaviour 
{

	// Use this for initialization
	void Start () 
	{
		if (Door.instance != null)
		{
			Door.instance.countCollectables++;
		}
	}
	
	
}
