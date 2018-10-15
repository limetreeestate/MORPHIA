using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Checkpoint : MonoBehaviour {
	public PlayerController controller;
	//private CharacterController controller;

	// Use this for initialization
	void Start () {
		//controller = GetComponent<CharacterController> ();
	}

	private void OnControllerColliderHit(ControllerColliderHit hit)
	{
		if (hit.gameObject.tag == "Player")
		{
			controller.setCheckpoint (this);
		}
	}
}
