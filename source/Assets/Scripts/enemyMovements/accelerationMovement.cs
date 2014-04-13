using UnityEngine;
using System.Collections;

public class accelerationMovement : MonoBehaviour {
	
	public Vector2 speed = new Vector2(0, 0);
	
	public Vector2 direction = new Vector2(-1, 0);
	
	private Vector2 movement;
	// Update is called once per frame
	void Update () {
		movement = new Vector2 (
			speed.x * direction.x,
			speed.y * direction.y);
		speed = new Vector2 (speed.x * 1.1f, speed.y *1.1f);
		if (speed.x >= 40) {
			speed.x = 40;
				}
		
	}
	void FixedUpdate()
	{
		rigidbody.velocity = movement;
	}
}