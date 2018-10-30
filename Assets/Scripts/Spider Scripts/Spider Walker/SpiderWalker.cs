using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderWalker : MonoBehaviour 
{
	[SerializeField]
	private Transform startPos, endPos;

	private bool collision_check;
	private float speed = 1f;
	private Rigidbody2D myBody;

	void Awake()
	{
		myBody = GetComponent<Rigidbody2D> ();
	}

	// Use this for initialization
	void Start () 
	{
		
	}
	
	void FixedUpdate()
	{
		Move();
		ChangeDirection();
	}

	void Move()
	{
		myBody.velocity = new Vector2(transform.localScale.x, 0) * speed;
	}

	/*
		using line cast for detect the whole line collision
	*/
	void ChangeDirection()
	{
		collision_check = Physics2D.Linecast(startPos.position, endPos.position, 1 << LayerMask.NameToLayer("Ground"));

		Debug.DrawLine(startPos.position, endPos.position, Color.red);

		if (!collision_check)
		{
			Vector3 temp = transform.localScale;

			if(temp.x == 1f)
			{
				temp.x = -1f;
			}
			else
			{
				temp.x = 1f;
			}

			transform.localScale = temp;
		}
	}
}
