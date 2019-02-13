using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
	public static Door instance;

	private Animator anim;
	private BoxCollider2D box;

	[HideInInspector]
	public int countCollectables;

	void Awake ()
	{
		MakeInstance ();
		anim = GetComponent<Animator> ();
		box = GetComponent<BoxCollider2D> ();
	}

	void MakeInstance ()
	{
		if (instance == null)
		{
			instance = this;
		}
	}

	public void DecrementCollectables ()
	{
		countCollectables--;

		if (countCollectables == 0)
		{
			StartCoroutine (OpenDoor ());
		}
	}

	IEnumerator OpenDoor ()
	{
		anim.Play ("Open");
		yield return new WaitForSeconds (0.7f);
		box.isTrigger = true;
	}

	void OnTriggerEnter2D (Collider2D target)
	{
		if (target.tag == "Player")
		{
			if (SceneManager.GetActiveScene ().name == "GameplayOne")
			{
				SceneManager.LoadScene ("GameplayTwo", LoadSceneMode.Single);
			}
			else if (SceneManager.GetActiveScene ().name == "GameplayTwo")
			{
				SceneManager.LoadScene ("GameplayThree", LoadSceneMode.Single);
			}
			else if (SceneManager.GetActiveScene ().name == "GameplayThree")
			{
				SceneManager.LoadScene ("Gameplay", LoadSceneMode.Single);
			}
			else if (SceneManager.GetActiveScene ().name == "Gameplay")
			{
				SceneManager.LoadScene ("Reserve", LoadSceneMode.Single);
			}

		}

		/*
			here
			 
			target.tag 
			and 
			target.gameObject.tag 
			
			both works on
		*/
	}
}