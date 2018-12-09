using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interactable : MonoBehaviour {

	public Transform player;
	Player_Controller pc;
	public float minDistance;

	void Start() {
		player = GameObject.Find("Player").transform;
		pc = player.GetComponent<Player_Controller> ();
	}

	void Update() {
		if (Vector3.Distance(player.position, transform.position) < minDistance) {
			pc.SetInteractable (this.GetComponent<Interactable> ());
		}
	}

	public void Interact() {
		Debug.Log ("Dis Object Was Interacted With");
	}
}
