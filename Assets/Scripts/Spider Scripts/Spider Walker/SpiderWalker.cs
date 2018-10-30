using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderWalker : MonoBehaviour 
{

	private float speed = 1f;
	private Rigidbody2D myBody;

	void Awake()
	{
		myBody = GetComponent<Rigidbody2D> ();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	void FixedUpdate()
	{
		Move();
	}

	void Move()
	{
		myBody.velocity = new Vector2(transform.localScale.x, 0) * speed;
	}
}
