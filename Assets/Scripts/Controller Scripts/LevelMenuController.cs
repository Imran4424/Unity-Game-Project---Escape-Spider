using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelMenuController : MonoBehaviour 
{

	public void Back()
	{
		SceneManager.LoadScene("MainMenu", LoadSceneMode.Single);
	}
}
