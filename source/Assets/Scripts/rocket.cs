using UnityEngine;
using System.Collections;

public class rocket : MonoBehaviour {
	public Rigidbody rocketClass;
	private bool mouseDown;
	public bool canrocket = true;
	
	void Update() {
		if (canrocket = true){
		if (Input.GetMouseButtonDown(1) && !mouseDown){
			mouseDown = true;
			Debug.Log("Creating rocket");
			
			Rigidbody clone;
			clone = Instantiate(rocketClass, transform.position, transform.rotation) as Rigidbody;
		}
		
		if (Input.GetMouseButtonUp(1) && mouseDown) {
			mouseDown = false;
		}
		}
	}
}
