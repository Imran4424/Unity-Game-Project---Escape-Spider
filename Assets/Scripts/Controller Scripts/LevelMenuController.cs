using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenuController : MonoBehaviour 
{

	public void LevelOne()
	{
		SceneManager.LoadScene("Gameplay", LoadSceneMode.Single);
	}

	public void Back()
	{
		SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
	}
}
