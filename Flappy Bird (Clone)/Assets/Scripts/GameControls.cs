using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class GameControls : MonoBehaviour {

	public static GameControls instance;
	public GameObject gameOverText;
	public bool endGame = false;

	private int score = 0;
	public Text scoreText;

	// Use this for initialization
	void Awake () {

		if(instance == null)
		{
			instance = this;
		}
		else if(instance != this)
		{
			Destroy(gameObject);
		}
		
	}
	
	// Update is called once per frame
	void Update ()
	{
		
		if(endGame == true && Input.GetMouseButtonDown(0))
		{
			int currentScene = SceneManager.GetActiveScene().buildIndex;
			SceneManager.LoadScene(currentScene);
		}

	}

	public void BirdDied()
	{
		gameOverText.SetActive(true);
		endGame = true;
	}

	public void BirdScored()
	{
		score = score + 1;
		scoreText.text = "Score:" + score.ToString();
	}


}
