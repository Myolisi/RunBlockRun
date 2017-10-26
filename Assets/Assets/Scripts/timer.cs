using UnityEngine;
using System.Collections;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class timer : MonoBehaviour {
	public float gameTimer;
	public Text timerLabel;

	// Use this for initialization
	void Start () {
	
	}
	
	public void GameTimer()
	{
		gameTimer -= Time.deltaTime;
		timerLabel.text = "Timer: " + Mathf.Round(gameTimer);

		if (gameTimer <= 0)
		{
			timerLabel.text = "Timer: 0";
            SceneManager.UnloadScene(1);
		}

	}

	public void Update()
	{
		GameTimer();
	}
}
