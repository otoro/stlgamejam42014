using UnityEngine;
using System.Collections;

public class backandforthAcceleration : MonoBehaviour {
	
	public Vector2 speed = new Vector2(1, 0);
	
	public Vector2 direction = new Vector2(1, 0);

	public Vector2 directionSwitch = new Vector2 (-1f, 1f);
	
	private Vector2 movement;

	private bool canswitch = true;
	// Update is called once per frame
	void Update () {
		movement = new Vector2 (
			speed.x * direction.x,
			speed.y * direction.y);
		speed = new Vector2 (speed.x * 1.1f, speed.y *1.1f);
		if (speed.x >= 40) {
			direction = new Vector2 (direction.x * directionSwitch.x,direction.y * directionSwitch.y);
			if (canswitch = true)
			{
			speed.x = 1;
			}
			canswitch =false;
		}
		if ((speed.x >=30) && (speed.x <= 30))
		{
			canswitch =true;
		}
		
	}
	void FixedUpdate()
	{
		rigidbody2D.velocity = movement;
	}
}
