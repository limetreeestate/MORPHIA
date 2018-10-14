using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class ButtonScript : MonoBehaviour, IPointerUpHandler, IPointerDownHandler {
	public PlayerController controller;
	public virtual void OnPointerUp(PointerEventData p)
	{
		controller.stop ();
	}

	public virtual void OnPointerDown(PointerEventData p)
	{
		controller.backward ();
	}
	
}
