using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class levelManager : MonoBehaviour {
	private int hitpoint = 3;
	private int score = 0;

	public Text lifeText;
	public Text scoreText;

	public Checkpoint spawnPosition;
	public Transform playerTransform;
	public PlayerController controller;
    public GameObject pauseMenu;

	public static levelManager instance { set; get; }

    private void Start()
    {
        pauseMenu.SetActive(false);
    }
    private void Awake()
	{
		instance = this;
		lifeText.text = "Lives: " + hitpoint.ToString();
		scoreText.text = "Current Score: " + score.ToString();


	}
	private void Update() {
		scoreText.text = "Current Score: " + score.ToString();

		if (playerTransform.position.y < -20) {
			controller.reset ();
			hitpoint--;
			lifeText.text = "Lives: " + hitpoint.ToString();
			if (hitpoint <= 0) {
                toMenu();
			}
		}

	}
	public void win() {
		if (PlayerPrefs.GetInt("PlayerScore")<score)
		{
			PlayerPrefs.SetInt("PlayerScore", score);
		}
        toMenu();
	}
	public void collectCoin() {
		score += 5;
		scoreText.text = "Current Score: " + score.ToString();
	}
	public void collectLife()
	{
		if (hitpoint < 3)
		{
			hitpoint++;
			lifeText.text = "Lives: " + hitpoint.ToString();
		}
	}

    public void toMenu()
    {
        SceneManager.LoadScene("menu");
    }

    public void togglePauseMenu()
    {
        pauseMenu.SetActive(!pauseMenu.activeSelf);
    }

}
