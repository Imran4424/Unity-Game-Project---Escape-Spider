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
		MakeInstance();
		anim = GetComponent<Animator>();
		box = GetComponent<BoxCollider2D>();
	}

	void MakeInstance()
	{
		if (instance == null)
		{
			instance = this;
		}
	}

	public void DecrementCollectables()
	{
		
	}

	IEnumerator OpenDoor()
	{
		anim.Play("Open");
		yield return new WaitForSeconds(0.7f);
		box.isTrigger = true;
	}
	
	// Update is called once per frame
	void Update () 
	{

	}
}
