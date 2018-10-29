using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpiderShooter : MonoBehaviour {

	[SerializeField]
	private GameObject bullet;
	
	// Use this for initialization
	void Start () 
	{
		
	}

	IEnumerator Attack()
	{
		yield return new WaitForSeconds(Random.Range(2,7));

		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
