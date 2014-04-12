using UnityEngine;
using System.Collections;

public class MissleLauncher : MonoBehaviour {
	public Rigidbody missleClass;
	private bool mouseDown;

	public int MissleSpeed = 100;

	void Update() {
		if (Input.GetMouseButtonDown(0) && !mouseDown){
			mouseDown = true;
			Debug.Log("Creating Missile");

			Rigidbody clone;
			clone = Instantiate(missleClass, transform.position, transform.rotation) as Rigidbody;
			clone.velocity = new Vector2(MissleSpeed, 0);
		}

		if (Input.GetMouseButtonUp(0) && mouseDown) {
			mouseDown = false;
		}
	}
}
