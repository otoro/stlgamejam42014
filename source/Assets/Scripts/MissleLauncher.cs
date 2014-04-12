using UnityEngine;
using System.Collections;

public class MissleLauncher : MonoBehaviour {
	public Rigidbody2D missleClass;
	private bool mouseDown;

	void Start () {	}

	void Update() {
		if (Input.GetMouseButtonDown(0) && !mouseDown){
			mouseDown = true;
			Debug.Log("Creating Missile");

			Rigidbody2D clone;
			clone = Instantiate(missleClass, transform.position, transform.rotation) as Rigidbody2D;
			clone.velocity = new Vector2(8000, 6000);
		}

		if (Input.GetMouseButtonUp(0) && mouseDown) {
			mouseDown = false;
		}
	}
}
