using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{

	public float moveForce = 20f, jumpForce = 700f, maxVelocity = 4f;

	private bool grounded;

	private Rigidbody2D myBody;
	private Animator anim;

	void Awake ()
	{
		InitializeVariables ();
	}

	// Use this for initialization
	void Start ()
	{

	}

	// Update is called once per frame
	void FixedUpdate ()
	{

	}

	void InitializeVariables ()
	{
		myBody = GetComponent<Rigidbody2D> ();
		anim = GetComponent<Animator> ();
	}

	void PlayerWalkKeyboard ()
	{
		float forceX = 0f;
		float forceY = 0f;

		float velocity = Mathf.Abs (myBody.velocity.x);

		float h = Input.GetAxisRaw ("Horizontal");

		if (h > 0)
		{
			if (velocity < maxVelocity)
			{
				forceX = moveForce;
			}

			Vector3 scale = transform.localScale;
			scale.x = 1f;
			transform.localScale = scale;

			anim.SetBool ("Walk", true);
		}
		else if (h < 0)
		{
			if (velocity < maxVelocity)
			{
				forceX = -moveForce;
			}

			Vector3 scale = transform.localScale;
			scale.x = -1f;
			transform.localScale = scale;

			anim.SetBool ("Walk", true);
		}
		else if (h == 0)
		{
			anim.SetBool ("Walk", false);
		}

		myBody.AddForce(new Vector2(forceX, forceY));
	}
}