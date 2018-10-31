using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BouncyScripts : MonoBehaviour 
{
	
	private float force = 500f;
	private Animator anim;

	void Awake()
	{
		anim = GetComponent<Animator>();
	}

	IEnumerator AnimationBouncy()
	{
		anim.Play("Up");
		yield return new WaitForSeconds(0.5f);
		anim.Play("Down");
	}
	

	/*
		We can targeted object script using the following function
	*/
	void OnTriggerEnter2D(Collider2D target)
	{
		if (target.tag == "Player")
		{
			target.gameObject.GetComponent<PlayerScript>().BouncePlayerWithBouncy(force);

			StartCoroutine(AnimationBouncy());
		}
	}
}
