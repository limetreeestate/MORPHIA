using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour {
	public PlayerController controller;

	private void OnControllerColliderHit(ControllerColliderHit hit)
	{
		Debug.Log ("Checkpoint collision");
		if (hit.gameObject.tag == "Player")
		{
			controller.setCheckpoint (this);
		}
	}

	private void OnCollisionEnter(Collision c)
	{
		Debug.Log ("Checkpoint collision");
		if (c.gameObject.tag == "Player")
		{
			controller.setCheckpoint (this);
		}
	}
}
