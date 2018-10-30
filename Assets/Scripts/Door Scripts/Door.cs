using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour 
{
	public static Door instance;

	private Animator anim;
	private BoxCollider2D box;

	[HideInInspector]
	public int countCollectables; 

	void Awake()
	{
		
	}

	void MakeInstance()
	{
		if (instance == null)
		{
			instance = this;
		}
	}
	
	// Update is called once per frame
	void Update () 
	{

	}
}
