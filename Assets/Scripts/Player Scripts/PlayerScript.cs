using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {

	public float moveForce = 20f, jumpForce = 700f, maxVelocity = 4f;

	private bool grounded;

	private Rigidbody2D myBody;
	private Animator anim;

	void Awake()
	{
		InitializeVariables();
	}
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		
	}

	void InitializeVariables()
	{
		myBody = GetComponent <Rigidbody2D> ();
		anim = GetComponent <Animator> ();
	}
}
