using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuController : MonoBehaviour 
{
	public void PlayGame()
	{
		SceneManager.LoadScene("LevelMenu", LoadSceneMode.Single);
	}

	public void About()
	{
		SceneManager.LoadScene("About", LoadSceneMode.Single);
	}

	public void Exit()
	{
		Application.Quit();
	}
}
