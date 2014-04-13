using UnityEngine;
using System.Collections;

public class straitMovementForCamera : MonoBehaviour {

	public Vector2 speed = new Vector2(10, 10);

	public Vector2 direction = new Vector2(-1, 0);

	public bool canmove = true;

	private Vector2 movement;
	private Vector2 zero; 


	void OnTriggerEnter(Collider collider) {
		if (collider.gameObject.tag == "Finish"){
			canmove = false;
			Debug.Log ("triggered");
		}
		}
	// Update is called once per frame
	void Update () {
		movement = new Vector2 (
			speed.x * direction.x,
			speed.y * direction.y);

	}

	void FixedUpdate(){
		if (canmove) {
				rigidbody.velocity = movement;
		}
		else if (!canmove) {
			rigidbody.velocity = zero;
	}
}
}