using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vBtnScript : MonoBehaviour, IVirtualButtonEventHandler {

	private GameObject animationButton;
	private GameObject butterFly;
	private GameObject rabbitDance;

	// Use this for initialization
	void Start () {

		animationButton = GameObject.Find ("animationButton");
		VirtualButtonBehaviour vb = animationButton.GetComponent<VirtualButtonBehaviour> ();
		if (vb) {
			vb.RegisterEventHandler (this);
		}
		butterFly = GameObject.Find ("butterfly");
		rabbitDance = GameObject.Find ("rabbitDance");

	}

	public void OnButtonPressed(VirtualButtonBehaviour vb){

		Debug.Log ("Button Pressed");
		butterFly.GetComponent<Animation> ().Play ();
		rabbitDance.GetComponent<Animation> ().Play ();

	
	}

	public void OnButtonReleased(VirtualButtonBehaviour vb){

		butterFly.GetComponent<Animation> ().Stop ();
		rabbitDance.GetComponent<Animation> ().Stop ();
	
	}
}
