using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameplayController : MonoBehaviour
{
	[SerializeField]
	private GameObject pausePanel;

	[SerializeField]
	private Button resumeGame;

	public void PauseGame ()
	{
		Time.timeScale = 0f;
		pausePanel.SetActive (true);
		resumeGame.onClick.RemoveAllListeners ();
		resumeGame.onClick.AddListener (() => ResumeGame());
	}

	public void ResumeGame ()
	{
		Time.timeScale = 0f;
		pausePanel.SetActive (false);
	}

	public void RestartGame()
	{
		Time.timeScale = 1f;

		SceneManager.LoadScene("Gameplay", LoadSceneMode.Single);
	}

	public void GoToLevelMenu()
	{
		Time.timeScale = 1f;

		SceneManager.LoadScene("LevelMenu", LoadSceneMode.Single);
	}

	public void PlayerDied()
	{
		Time.timeScale = 0f;

		StartCoroutine(Wait());
	}

	IEnumerator Wait()
	{	
		yield return new WaitForSeconds(2f);

	}
}