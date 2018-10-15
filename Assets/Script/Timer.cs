using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Timer : MonoBehaviour {
	
	public Text timerText;
	public float timeLimit;
	private float startTime;
	// Use this for initialization
	void Start () {
		startTime = Time.time;
	}
	
	// Update is called once per frame
	void Update () {
		float remainingTime = timeLimit +  (startTime - Time.time);
		string minutes = ((int) remainingTime / 60).ToString ();
		string seconds = ((int) remainingTime % 60).ToString ();

		timerText.text = minutes + " : " + seconds;
		if (remainingTime < 0) 
		{
			timerText.text = "TIME IS UP";
			SceneManager.LoadScene ("menu");
		}
	}
}
