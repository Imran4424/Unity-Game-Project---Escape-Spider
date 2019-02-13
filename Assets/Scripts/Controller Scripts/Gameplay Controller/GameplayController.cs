using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameplayController : MonoBehaviour
{
	[SerializeField]
	private GameObject pausePanel, gameOverPanel;

	[SerializeField]
	private Button resumeGame, restartGame;

	public void PauseGame ()
	{
		Time.timeScale = 0f;
		pausePanel.SetActive (true);
		resumeGame.onClick.RemoveAllListeners ();
		resumeGame.onClick.AddListener (() => ResumeGame ());
	}

	public void ResumeGame ()
	{
		Time.timeScale = 1f;
		pausePanel.SetActive (false);
	}

	public void RestartGame ()
	{
		Time.timeScale = 1f;

		SceneManager.LoadScene ("Gameplay", LoadSceneMode.Single);
	}

	public void GoToLevelMenu ()
	{
		Time.timeScale = 1f;

		SceneManager.LoadScene ("LevelMenu", LoadSceneMode.Single);
	}

	public void PlayerDied ()
	{
		Time.timeScale = 0f;
		pausePanel.SetActive (true);
		resumeGame.onClick.RemoveAllListeners ();
		resumeGame.onClick.AddListener (() => RestartGame ());
	}

	IEnumerator Wait ()
	{
		yield return new WaitForSeconds (2f);

	}
}