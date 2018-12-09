using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Controller : MonoBehaviour {

	public float Player_Speed;

	Transform trans;
	Interactable interactable_object;

	void Start () {
		trans = gameObject.transform;
	}

	// Update is called once per frame
	void Update () {
		MoveLeft (Input.GetAxisRaw ("Horizontal"));
		MoveUp (Input.GetAxisRaw ("Vertical"));

		if (Input.GetAxisRaw ("Interact") > 0) {
			InteractWith ();
		}
	}



	void MoveLeft(float axis) {
		trans.position += Vector3.left * Player_Speed * axis;
	}

	void MoveUp(float axis) {
		trans.position += Vector3.up * Player_Speed * axis;
	}
		

	void InteractWith() {
		interactable_object.Interact ();
	}

	// Public Classes
	public void SetInteractable(Interactable interactable_object) {
		this.interactable_object = interactable_object;
	}


}
