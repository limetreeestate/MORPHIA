using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour {
	public PlayerController controller;

	private void OnTriggerEnter(Collider c)
	{
		Debug.Log ("Checkpoint collision");
		if (c.gameObject.tag == "Player")
		{
			controller.setCheckpoint (this);
		}
	}

}
