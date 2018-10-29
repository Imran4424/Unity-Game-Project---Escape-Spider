using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderJumper : MonoBehaviour 
{

	private float forceY;
	private Rigidbody2D myBody;
	private Animator anim;

	void Awake()
	{
		myBody = GetComponent <Rigidbody2D> ();
		anim = GetComponent <Animator> ();
	}

	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}
}
