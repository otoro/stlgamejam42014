using UnityEngine;
using System.Collections;

public class circleMovement : MonoBehaviour {
	public float angularVelocity; // radians per second
	public GameObject pointOfRotation; // game object to rotate around

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		this.transform.RotateAround (pointOfRotation.transform.position, 
		                             Vector3.forward, 
		                             angularVelocity);
	}
}
