using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class JumpButtonScript : MonoBehaviour, IPointerDownHandler {
	public PlayerController controller;

	public virtual void OnPointerDown(PointerEventData p)
	{
		controller.jump ();
	}

}
